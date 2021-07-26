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
        private readonly RequestDelegate _next;
        private readonly IAuth _auth;
        private readonly AccountDomainService<R_Admin> _adminDomainService;
        private readonly AccountDomainService<R_Driver> _driverDomainService;
        private readonly AccountDomainService<R_Guest> _guestDomainService;

        public JwtMiddleware(RequestDelegate next, IAuth auth,
            AccountDomainService<R_Admin> adminDomainService,
            AccountDomainService<R_Driver> driverDomainService,
            AccountDomainService<R_Guest> guestDomainService)
        {
            _next = next;
            _auth = auth;
            _adminDomainService = adminDomainService;
            _driverDomainService = driverDomainService;
            _guestDomainService = guestDomainService;
        }

        public async Task Invoke(HttpContext context, IAccountService accountService)
        {
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

                var id = _auth.GetClaim(token, "id");
                var role = _auth.GetClaim(token, "role");
                object user = null;

                if (role == E_AccountType.Admin.ToString())
                {
                    user = _adminDomainService.GetAccountById(id);
                }
                else if (role == E_AccountType.Driver.ToString())
                {
                    user = _driverDomainService.GetAccountById(id);
                }
                else if (role == E_AccountType.Guest.ToString())
                {
                    user = _guestDomainService.GetAccountById(id);
                }
                else {
                    throw new Exception("User is null in JwtMiddleware");
                }

                // attach user to context on successful jwt validation
                context.Items["User"] = user;
            }
            catch
            {
                // do nothing if jwt validation fails
                throw new Exception("Happen error in try catch, user is null in JwtMiddleware");
            }
        }
    }
}
