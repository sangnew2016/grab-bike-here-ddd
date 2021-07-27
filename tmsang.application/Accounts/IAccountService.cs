namespace tmsang.application
{
    public interface IAccountService
    {
        TokenDto GuestLogin(GuestLoginDto loginDto);
        TokenDto DriverLogin(DriverLoginDto loginDto);
        TokenDto AdminLogin(AdminLoginDto loginDto);

        void GuestRegister(GuestRegisterDto registerDto);
        void DriverRegister(DriverRegisterDto registerDto);
        void AdminRegister(AdminRegisterDto registerDto);

        void GuestForgotPassword(string email);
        void DriverForgotPassword(string email);
        void AdminForgotPassword(string email);

        TokenDto GuestResetPassword(GuestResetPasswordDto resetPasswordDto);
        TokenDto DriverResetPassword(DriverResetPasswordDto resetPasswordDto);
        TokenDto AdminResetPassword(AdminResetPasswordDto resetPasswordDto);

        TokenDto GuestChangePassword(GuestChangePasswordDto changePasswordDto);
        TokenDto DriverChangePassword(DriverChangePasswordDto changePasswordDto);
        TokenDto AdminChangePassword(AdminChangePasswordDto changePasswordDto);

        void SendSmsCode(string phone);
    }
}
