using System;

namespace tmsang.application
{
    public class ResetPasswordDto
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
    }

    public class GuestResetPasswordDto: ResetPasswordDto
    {
    }

    public class DriverResetPasswordDto: ResetPasswordDto
    {
        public string SmsCode { get; set; }
    }

    public class AdminResetPasswordDto: ResetPasswordDto
    {
        public string SmsCode { get; set; }

        public void EmptyValidation()
        {
            if (string.IsNullOrEmpty(this.Email)) throw new Exception("Email value is null or empty");
            if (string.IsNullOrEmpty(this.NewPassword)) throw new Exception("Password is null or empty");
            if (string.IsNullOrEmpty(this.SmsCode)) throw new Exception("SmsCode value is null or empty");
        }
    }
}
