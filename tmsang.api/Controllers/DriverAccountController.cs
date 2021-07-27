using Microsoft.AspNetCore.Mvc;
using tmsang.application;

namespace tmsang.api
{
    public class DriverAccountController : Controller
    {
        readonly IAccountService accountService;

        public DriverAccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("register")]
        public void Register(DriverRegisterDto registerDto)
        {
            try
            {
                this.accountService.DriverRegister(registerDto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("login")]
        public TokenDto Login(DriverLoginDto loginDto)
        {
            try
            {
                return this.accountService.DriverLogin(loginDto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("forgot")]
        public void ForgotPassword(string email)
        {
            try
            {
                this.accountService.DriverForgotPassword(email);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("reset")]
        public TokenDto ResetPassword(DriverResetPasswordDto resetPasswordDto)
        {
            try
            {
                return this.accountService.DriverResetPassword(resetPasswordDto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [Authorize]
        [HttpPost("change")]
        public TokenDto ChangePassword(DriverChangePasswordDto changePasswordDto)
        {
            try
            {
                return this.accountService.DriverChangePassword(changePasswordDto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpGet("smscode")]
        public void SmsCode(string phone)
        {
            try
            {
                this.accountService.SendSmsCode(phone);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
