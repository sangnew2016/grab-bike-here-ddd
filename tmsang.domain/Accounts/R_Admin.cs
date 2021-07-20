using System;

namespace tmsang.domain
{
    public class R_Admin : R_Account
    {
        public virtual string FullName { get; protected set; }
        public virtual string Phone { get; protected set; }
        public virtual string Email { get; protected set; }
        public virtual string Password { get; protected set; }
        public virtual byte[] Salt { get; protected set; }


        public static R_Admin Create(string fullName, string phone, string email, string password, byte[] salt) {
            return Create(Guid.NewGuid(), fullName, phone, email, password, salt);
        }
        public static R_Admin Create(Guid id, string fullName, string phone, string email, string password, byte[] salt)
        {
            var admin = new R_Admin { 
                Id = id,
                FullName = fullName,
                Phone = phone,
                Email = email,
                Password = password,
                Salt = salt,
                AccountStatusId = (int)E_AccountStatus.Active           // tam thoi chua check mail, nen de la 1 - active
            };

            DomainEvents.Raise<R_AdminCreatedEvent>(new R_AdminCreatedEvent { R_Admin = admin });

            return admin;
        }

        public virtual void ResetPassword(string newPassword) {
            this.Password = newPassword;
        }
    }
}
