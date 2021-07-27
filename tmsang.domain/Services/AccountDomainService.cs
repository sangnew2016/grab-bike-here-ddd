namespace tmsang.domain
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

        //=============================================
        // ADMIN
        //=============================================
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
            var r_AdminGetByEmailSpec = new R_AdminGetByEmailSpec(email);
            var user = this.adminAccountRepository.FindOne(r_AdminGetByEmailSpec);

            return user;
        }

        //=============================================
        // DRIVER
        //=============================================
        public R_Driver GetDriverById(string id)
        {
            // doi chieu email/phone voi database
            var r_DriverGetByIdSpec = new R_DriverGetByIdSpec(id);
            var user = this.driverAccountRepository.FindOne(r_DriverGetByIdSpec);

            return user;
        }

        public R_Driver GetDriverByEmail(string email)
        {
            // doi chieu email/phone voi database
            var r_DriverGetByEmailSpec = new R_DriverGetByEmailSpec(email);
            var user = this.driverAccountRepository.FindOne(r_DriverGetByEmailSpec);

            return user;
        }

        //=============================================
        // GUEST
        //=============================================
        public R_Guest GetGuestById(string id)
        {
            // doi chieu email/phone voi database
            var r_GuestGetByIdSpec = new R_GuestGetByIdSpec(id);
            var user = this.guestAccountRepository.FindOne(r_GuestGetByIdSpec);

            return user;
        }

        public R_Guest GetGuestByEmail(string email)
        {
            // doi chieu email/phone voi database
            var r_GuestGetByEmailSpec = new R_GuestGetByEmailSpec(email);
            var user = this.guestAccountRepository.FindOne(r_GuestGetByEmailSpec);

            return user;
        }

    }
}
