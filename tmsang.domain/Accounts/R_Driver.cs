using System;

namespace tmsang.domain
{
    public class R_Driver: R_Account
    {
        public virtual string FirstName { get; protected set; }
        public virtual string LastName { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Phone { get; protected set; }
        public virtual string PersonalId { get; protected set; }
        public virtual string PersonalImage { get; protected set; }
        public virtual string Address { get; protected set; }
        public virtual string Password { get; protected set; }
        public virtual byte[] Salt { get; protected set; }

        public static R_Driver Create(string firstName, string lastName, string personId, string personImage, string address, string phone, string email, string password, byte[] salt)
        {
            return Create(Guid.NewGuid(), firstName, lastName, personId, personImage, address, phone, email, password, salt);
        }
        public static R_Driver Create(Guid id, string firstName, string lastName, string personId, string personImage, string address, string phone, string email, string password, byte[] salt)
        {
            var user = new R_Driver
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                PersonalId = personId,
                PersonalImage = personImage,
                Address = address,
                Phone = phone,
                Email = email,
                Password = password,
                Salt = salt,
                AccountStatusId = (int)E_AccountStatus.Active           // tam thoi chua check mail, nen de la 1 - active
            };

            DomainEvents.Raise<R_DriverCreatedEvent>(new R_DriverCreatedEvent { R_Driver = user });

            return user;
        }
        public virtual void ResetPassword(string newPassword)
        {
            this.Password = newPassword;
        }
    }
}
