using System;

namespace tmsang.application
{
    public class RegisterDto
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string SmsCode { get; set; }
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

    public class DriverRegisterDto : RegisterDto
    {
        // thong tin account
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Male { get; set; }
        public string PersonalId { get; set; }      // chung minh nhan dan | can cuoc cong nhan
        public string Address { get; set; }
        public string Avatar { get; set; }          // hinh 3x4

        // thong tin dang ky xe cua Driver
        public string PlateNo { get; set; }         // bang so xe: 59C1-22983
        public string BikeOwner { get; set; }       // chu xe: THACH MINH SANG
        public string EngineNo { get; set; }        // so may: 2324890
        public string ChassisNo { get; set; }       // so khung: 435-2134
        public string BikeType { get; set; }        // loai xe: VISION        
        public string Brand { get; set; }           // hang xe: HONDA
        public DateTime RegistrationDate { get; set; }

        public void EmptyValidation()
        {
            if (string.IsNullOrEmpty(this.Email)) throw new Exception("Email value is null or empty");
            if (string.IsNullOrEmpty(this.Phone)) throw new Exception("Phone value is null or empty");
            if (string.IsNullOrEmpty(this.Password)) throw new Exception("Password value is null or empty");
            if (string.IsNullOrEmpty(this.FirstName)) throw new Exception("FirstName value is null or empty");
            if (string.IsNullOrEmpty(this.LastName)) throw new Exception("LastName value is null or empty");
            if (this.Birthday >= DateTime.Now) throw new Exception("Birthday is invalid");
            if (string.IsNullOrEmpty(this.PersonalId)) throw new Exception("PersonalId value is null or empty");
            if (string.IsNullOrEmpty(this.Address)) throw new Exception("Address value is null or empty");
            if (string.IsNullOrEmpty(this.Avatar)) throw new Exception("Avatar value is null or empty");

            if (string.IsNullOrEmpty(this.PlateNo)) throw new Exception("PlateNo value is null or empty");
            if (string.IsNullOrEmpty(this.BikeOwner)) throw new Exception("BikeOwner value is null or empty");
            if (string.IsNullOrEmpty(this.EngineNo)) throw new Exception("EngineNo value is null or empty");
            if (string.IsNullOrEmpty(this.ChassisNo)) throw new Exception("ChassisNo value is null or empty");
            if (string.IsNullOrEmpty(this.BikeType)) throw new Exception("BikeType value is null or empty");
            if (string.IsNullOrEmpty(this.Brand)) throw new Exception("Brand is invalid");

        }
    }

    public class GuestRegisterDto : RegisterDto
    {
        public string FullName { get; set; }

        public void EmptyValidation()
        {
            if (string.IsNullOrEmpty(this.Email)) throw new Exception("Email value is null or empty");
            if (string.IsNullOrEmpty(this.Phone)) throw new Exception("Phone value is null or empty");
            if (string.IsNullOrEmpty(this.Password)) throw new Exception("Password value is null or empty");
            if (string.IsNullOrEmpty(this.FullName)) throw new Exception("FullName value is null or empty");
        }
    }

}
