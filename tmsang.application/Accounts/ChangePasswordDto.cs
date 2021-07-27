using System;

namespace tmsang.application
{
    public class ChangePasswordDto
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string SmsCode { get; set; }
        public void EmptyValidation()
        {
            if (string.IsNullOrEmpty(this.OldPassword)) throw new Exception("Old Password is null or empty");
            if (string.IsNullOrEmpty(this.NewPassword)) throw new Exception("New Password is null or empty");
            if (string.IsNullOrEmpty(this.SmsCode)) throw new Exception("SmsCode value is null or empty");
        }
    }

    public class GuestChangePasswordDto: ChangePasswordDto
    {
    }

    public class DriverChangePasswordDto: ChangePasswordDto
    {
    }

    public class AdminChangePasswordDto: ChangePasswordDto
    {
    }
}
