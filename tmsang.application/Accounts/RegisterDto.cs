using System;

namespace tmsang.application
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }

    public class AdminRegisterDto : RegisterDto
    {
        public string Serial { get; set; }          // mat ma de nhan dang admin - hardcode
        public string FullName { get; set; }

        public void EmptyValidation() {
            if (string.IsNullOrEmpty(this.Email)) throw new Exception("Email value is null or empty");
            if (string.IsNullOrEmpty(this.Phone)) throw new Exception("Phone value is null or empty");
            if (string.IsNullOrEmpty(this.Password)) throw new Exception("Password value is null or empty");
            if (string.IsNullOrEmpty(this.Serial)) throw new Exception("Serial value is null or empty");
            if (string.IsNullOrEmpty(this.FullName)) throw new Exception("FullName value is null or empty");
        }
        
    }

    public class GuestRegisterDto : RegisterDto
    {
        public string FullName { get; set; }
    }

    public class DriverRegisterDto : RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Male { get; set; }
        public string PersonalId { get; set; }      // chung minh nhan dan | can cuoc cong nhan
        public string Address { get; set; }
        public string Avatar { get; set; }          // hinh 3x4

    }

    public class DriverBikeRegisterDto
    {
        public string PlateNo { get; set; }         // bang so xe: 59C1-22983
        public string BikeOwner { get; set; }       // chu xe: THACH MINH SANG
        public string EngineNo { get; set; }        // so may: 2324890
        public string ChassisNo { get; set; }       // so khung: 435-2134
        public string BikeType { get; set; }        // loai xe: VISION        
        public string Brand { get; set; }           // hang xe: HONDA
        public DateTime RegistrationDate { get; set; }

    }
}
