using Microsoft.AspNetCore.Mvc;
using tmsang.application;

namespace tmsang.api
{
    public class GuestAccountController : Controller
    {
        readonly IAccountService accountService;

        public GuestAccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("register")]
        public void Register(GuestRegisterDto registerDto)
        {
            try
            {
                this.accountService.GuestRegister(registerDto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("login")]
        public TokenDto Login(GuestLoginDto loginDto)
        {
            try
            {
                return this.accountService.GuestLogin(loginDto);
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
                this.accountService.GuestForgotPassword(email);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost("reset")]
        public TokenDto ResetPassword(GuestResetPasswordDto resetPasswordDto)
        {
            try
            {
                return this.accountService.GuestResetPassword(resetPasswordDto);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [Authorize]
        [HttpPost("change")]
        public TokenDto ChangePassword(GuestChangePasswordDto changePasswordDto)
        {
            try
            {
                return this.accountService.GuestChangePassword(changePasswordDto);
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
