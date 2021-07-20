using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tmsang.domain;

namespace tmsang.infra
{
    public class MysqlDbContext: DbContext
    {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
        {
        }

        public DbSet<R_Admin> R_Admins { get; set; }
        public DbSet<R_Driver> R_Drivers { get; set; }
        public DbSet<R_Guest> R_Guests { get; set; }
        public DbSet<R_Account> R_Accounts { get; set; }
        public DbSet<B_AccountHistory> B_AccountHistories { get; set; }
        public DbSet<B_DriverBike> B_DriverBikes { get; set; }

        public DbSet<M_AccountTrackingType> M_AccountTrackingTypes { get; set; }
        public DbSet<M_Area> M_Areas { get; set; }
        public DbSet<M_OrderTrackingType> M_OrderTrackingTypes { get; set; }
        public DbSet<M_PersonalPolicyType> M_PersonalPolicyTypes { get; set; }
        public DbSet<M_RoutineCost> M_RoutineCosts { get; set; }
        public DbSet<M_TaxVAT> M_TaxVATs { get; set; }

        public DbSet<R_Order> R_Orders { get; set; }
        public DbSet<R_OrderRequest> R_OrderRequests { get; set; }
        public DbSet<R_OrderResponse> R_OrderResponses { get; set; }
        public DbSet<R_OrderPayment> r_OrderPayments { get; set; }
        public DbSet<R_OrderEvaluation> R_OrderEvaluations { get; set; }
        public DbSet<R_Location> R_Locations { get; set; }
        public DbSet<B_OrderRequestLocation> B_OrderRequestLocations { get; set; }
        public DbSet<B_OrderPaymentCreditCard> B_OrderPaymentCreditCards { get; set; }
        public DbSet<B_OrderHistory> B_OrderHistories { get; set; }
        



    }
}
