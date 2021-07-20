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


        public TokenDto Login(DriverLoginDto loginDto)
        {
            // tra ve token
            return this.accountService.DriverLogin(loginDto);
        }

        public void Register(DriverRegisterDto registerDto)
        {
            // register se email, kich hoat account thong qua email
            this.accountService.DriverRegister(registerDto);
        }

        public void ForgotPassword(string email)
        {
            // forgot se email, link(co token: verifyResetPasswordToken) co expire sau 1h - kich hoat se hien thi Form "Reset Password"
            this.accountService.ForgotPassword(email);
        }

        public TokenDto ResetPassword(DriverResetPasswordDto resetPasswordDto)
        {
            // ResetPasswordDto: [verifyResetPasswordToken, email, new password, sms code]
            // Reset Password tra ve token, cho phep User login ngay va luon
            return this.accountService.DriverResetPassword(resetPasswordDto);
        }
    }
}
