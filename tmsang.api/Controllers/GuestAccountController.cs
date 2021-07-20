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

        
        public TokenDto Login(GuestLoginDto loginDto) 
        {
            // tra ve token
            return this.accountService.GuestLogin(loginDto);
        }

        public void Register(GuestRegisterDto registerDto)
        {
            // register se email, kich hoat account thong qua email
            this.accountService.GuestRegister(registerDto);
        }

        public void ForgotPassword(string email)
        {
            // forgot se email, link(co token: verifyResetPasswordToken) co expire sau 1h - kich hoat se hien thi Form "Reset Password"
            this.accountService.ForgotPassword(email);
        }

        public TokenDto ResetPassword(GuestResetPasswordDto resetPasswordDto)
        {
            // ResetPasswordDto: [verifyResetPasswordToken, email, new password, sms code]
            // Reset Password tra ve token, cho phep User login ngay va luon
            return this.accountService.GuestResetPassword(resetPasswordDto);
        }

    }
}
