using System;

namespace tmsang.application
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public void EmptyValidation()
        {
            if (string.IsNullOrEmpty(this.Email)) throw new Exception("Email value is null or empty");
            if (string.IsNullOrEmpty(this.Password)) throw new Exception("Password value is null or empty");
        }
    }

    public class GuestLoginDto : LoginDto
    {
    }

    public class DriverLoginDto : LoginDto
    {
    }

    public class AdminLoginDto : LoginDto
    {
    }
}
