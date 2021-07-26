using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tmsang.domain;

namespace tmsang.infra
{
    public class MyDbContext: DbContext
    {
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
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


        public override int SaveChanges()
        {
            var entities = from e in ChangeTracker.Entries()
                           where e.State == EntityState.Added
                               || e.State == EntityState.Modified
                           select e.Entity;
            foreach (var entity in entities)
            {
                var validationContext = new ValidationContext(entity);
                Validator.ValidateObject(entity, validationContext);
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<R_Account>().ToTable("R_Accounts");
            modelBuilder.Entity<R_Admin>().ToTable("R_Admins");
            modelBuilder.Entity<R_Driver>().ToTable("R_Drivers");
            modelBuilder.Entity<R_Guest>().ToTable("R_Guests");
            modelBuilder.Entity<B_DriverBike>().ToTable("B_DriverBikes");

            modelBuilder.Entity<B_AdminHistory>().ToTable("B_AdminHistories");
            modelBuilder.Entity<B_DriverHistory>().ToTable("B_DriverHistories");
            modelBuilder.Entity<B_GuestHistory>().ToTable("B_GuestHistories");

            modelBuilder.Entity<R_Order>().ToTable("R_Orders");
            modelBuilder.Entity<R_OrderRequest>().ToTable("R_OrderRequests");
            modelBuilder.Entity<R_OrderResponse>().ToTable("R_OrderResponses");
            modelBuilder.Entity<R_OrderPayment>().ToTable("R_OrderPayments");
            modelBuilder.Entity<R_OrderEvaluation>().ToTable("R_OrderEvaluations");
            modelBuilder.Entity<B_OrderPaymentCreditCard>().ToTable("B_OrderPaymentCreditCards");
            
            modelBuilder.Entity<B_OrderRequestHistory>().ToTable("B_OrderRequestHistories");
            modelBuilder.Entity<B_OrderResponseHistory>().ToTable("B_OrderResponseHistories");
            modelBuilder.Entity<B_OrderPaymentHistory>().ToTable("B_OrderPaymentHistories");
            modelBuilder.Entity<B_OrderEvaluationHistory>().ToTable("B_OrderEvaluationHistories");
        }

    }
}
