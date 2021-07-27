﻿namespace tmsang.domain
{
    public class AccountDomainService
    {
        readonly IRepository<R_Admin> adminAccountRepository;
        readonly IRepository<R_Driver> driverAccountRepository;
        readonly IRepository<R_Guest> guestAccountRepository;

        public AccountDomainService(
            IRepository<R_Admin> adminAccountRepository,
            IRepository<R_Driver> driverAccountRepository,
            IRepository<R_Guest> guestAccountRepository)
        {
            this.adminAccountRepository = adminAccountRepository;
            this.driverAccountRepository = driverAccountRepository;
            this.guestAccountRepository = guestAccountRepository;
        }

        public bool CanExists(string email ,string phone) {
            // doi chieu email/phone voi database
            var r_AdminCheckRegisterAccountSpec = new R_AdminCheckRegisterAccountSpec(email, phone);
            var user = this.adminAccountRepository.FindOne(r_AdminCheckRegisterAccountSpec);
            
            return user != null;
        }

        public R_Admin GetAdminById(string id)
        {
            // doi chieu email/phone voi database
            var r_AdminGetByIdSpec = new R_AdminGetByIdSpec(id);
            var user = this.adminAccountRepository.FindOne(r_AdminGetByIdSpec);

            return user;
        }

        public R_Admin GetAdminByEmail(string email)
        {
            // doi chieu email/phone voi database
            var r_AdminGetRegisteredAccountSpec = new R_AdminGetByEmailSpec(email);
            var user = this.adminAccountRepository.FindOne(r_AdminGetRegisteredAccountSpec);

            return user;
        }
    }
}
