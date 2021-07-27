using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;
using tmsang.application;
using tmsang.domain;

namespace tmsang.api
{
    public class JwtMiddleware
    {
        private RequestDelegate _next;
        private IAuth _auth;
        private AccountDomainService _accountDomainService;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IAuth auth, AccountDomainService accountDomainService)
        {
            _auth = auth;
            _accountDomainService = accountDomainService;

            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                attachUserToContext(context, token);

            await _next(context);
        }

        private void attachUserToContext(HttpContext context, string token)
        {
            try
            {
                if (!_auth.ValidateCurrentToken(token)) {
                    throw new Exception("Your token is invalid");
                }

                var id = _auth.GetClaim(token, "nameid");
                var role = _auth.GetClaim(token, "role");
                object user = null;

                if (role == E_AccountType.Admin.ToString())
                {
                    user = _accountDomainService.GetAdminById(id);
                }
                //else if (role == E_AccountType.Driver.ToString())
                //{
                //    user = _accountDomainService.GetDriverById(id);
                //}
                //else if (role == E_AccountType.Guest.ToString())
                //{
                //    user = _accountDomainService.GetGuestById(id);
                //}
                else {
                    throw new Exception("User is null in JwtMiddleware");
                }

                // attach user to context on successful jwt validation
                context.Items["User"] = user;
                context.Items["Role"] = role;
            }
            catch
            {
                // do nothing if jwt validation fails
                throw new Exception("Happen error in try catch, user is null in JwtMiddleware");
            }
        }
    }
}
