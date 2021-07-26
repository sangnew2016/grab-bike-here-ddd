﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tmsang.infra;

namespace tmsang.infra.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210723075507_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("tmsang.domain.B_AccountHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.Property<int>("AccountTrackingTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HappenDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("B_AccountHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("HappenDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<int>("OrderTrackingTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("B_OrderHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderRequestLocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("FromLocationId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("OrderRequestId")
                        .HasColumnType("char(36)");

                    b.Property<long>("ToLocationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("B_OrderRequestLocations");
                });

            modelBuilder.Entity("tmsang.domain.M_AccountTrackingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("M_AccountTrackingTypes");
                });

            modelBuilder.Entity("tmsang.domain.M_Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Latitude")
                        .HasColumnType("longtext");

                    b.Property<string>("Longtitude")
                        .HasColumnType("longtext");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("M_Areas");
                });

            modelBuilder.Entity("tmsang.domain.M_OrderTrackingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("M_OrderTrackingTypes");
                });

            modelBuilder.Entity("tmsang.domain.M_PersonalPolicyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("M_PersonalPolicyTypes");
                });

            modelBuilder.Entity("tmsang.domain.M_RoutineCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("M_RoutineCosts");
                });

            modelBuilder.Entity("tmsang.domain.M_TaxVAT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<DateTime?>("From")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<DateTime?>("To")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("M_TaxVATs");
                });

            modelBuilder.Entity("tmsang.domain.R_Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccountStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("R_Accounts");
                });

            modelBuilder.Entity("tmsang.domain.R_Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Latitude")
                        .HasColumnType("longtext");

                    b.Property<string>("Longtitude")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("R_Locations");
                });

            modelBuilder.Entity("tmsang.domain.R_Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("R_Orders");
                });

            modelBuilder.Entity("tmsang.domain.B_AdminHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_AccountHistory");

                    b.ToTable("B_AdminHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_DriverHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_AccountHistory");

                    b.ToTable("B_DriverHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_GuestHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_AccountHistory");

                    b.ToTable("B_GuestHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderEvaluationHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_OrderHistory");

                    b.ToTable("B_OrderEvaluationHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderPaymentHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_OrderHistory");

                    b.ToTable("B_OrderPaymentHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderRequestHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_OrderHistory");

                    b.ToTable("B_OrderRequestHistories");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderResponseHistory", b =>
                {
                    b.HasBaseType("tmsang.domain.B_OrderHistory");

                    b.ToTable("B_OrderResponseHistories");
                });

            modelBuilder.Entity("tmsang.domain.R_Admin", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Account");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("longblob");

                    b.ToTable("R_Admins");
                });

            modelBuilder.Entity("tmsang.domain.R_Driver", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Account");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalId")
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalImage")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.ToTable("R_Drivers");
                });

            modelBuilder.Entity("tmsang.domain.R_Guest", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Account");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.ToTable("R_Guests");
                });

            modelBuilder.Entity("tmsang.domain.R_OrderEvaluation", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Order");

                    b.Property<string>("Note")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.ToTable("R_OrderEvaluations");
                });

            modelBuilder.Entity("tmsang.domain.R_OrderPayment", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Order");

                    b.Property<bool>("Paid")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.ToTable("R_OrderPayments");
                });

            modelBuilder.Entity("tmsang.domain.R_OrderRequest", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Order");

                    b.Property<Guid>("GuestId")
                        .HasColumnType("char(36)");

                    b.Property<long>("OrderRequestLocationId")
                        .HasColumnType("bigint");

                    b.Property<int>("OrderTrackingTypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("R_GuestId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime(6)");

                    b.HasIndex("R_GuestId");

                    b.ToTable("R_OrderRequests");
                });

            modelBuilder.Entity("tmsang.domain.R_OrderResponse", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Order");

                    b.Property<Guid>("DriverId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime(6)");

                    b.ToTable("R_OrderResponses");
                });

            modelBuilder.Entity("tmsang.domain.B_DriverBike", b =>
                {
                    b.HasBaseType("tmsang.domain.R_Driver");

                    b.Property<string>("BikeOwner")
                        .HasColumnType("longtext");

                    b.Property<string>("BikeType")
                        .HasColumnType("longtext");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("ChassisNo")
                        .HasColumnType("longtext");

                    b.Property<string>("EngineNo")
                        .HasColumnType("longtext");

                    b.Property<string>("PlateNo")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.ToTable("B_DriverBikes");
                });

            modelBuilder.Entity("tmsang.domain.B_OrderPaymentCreditCard", b =>
                {
                    b.HasBaseType("tmsang.domain.R_OrderPayment");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.ToTable("B_OrderPaymentCreditCards");
                });

            modelBuilder.Entity("tmsang.domain.B_AdminHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_AccountHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_AdminHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_DriverHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_AccountHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_DriverHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_GuestHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_AccountHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_GuestHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_OrderEvaluationHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_OrderHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_OrderEvaluationHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_OrderPaymentHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_OrderHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_OrderPaymentHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_OrderRequestHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_OrderHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_OrderRequestHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_OrderResponseHistory", b =>
                {
                    b.HasOne("tmsang.domain.B_OrderHistory", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_OrderResponseHistory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_Admin", b =>
                {
                    b.HasOne("tmsang.domain.R_Account", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_Driver", b =>
                {
                    b.HasOne("tmsang.domain.R_Account", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_Driver", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_Guest", b =>
                {
                    b.HasOne("tmsang.domain.R_Account", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_Guest", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_OrderEvaluation", b =>
                {
                    b.HasOne("tmsang.domain.R_Order", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_OrderEvaluation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_OrderPayment", b =>
                {
                    b.HasOne("tmsang.domain.R_Order", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_OrderPayment", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_OrderRequest", b =>
                {
                    b.HasOne("tmsang.domain.R_Order", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_OrderRequest", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("tmsang.domain.R_Guest", null)
                        .WithMany("OrderRequests")
                        .HasForeignKey("R_GuestId");
                });

            modelBuilder.Entity("tmsang.domain.R_OrderResponse", b =>
                {
                    b.HasOne("tmsang.domain.R_Order", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.R_OrderResponse", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_DriverBike", b =>
                {
                    b.HasOne("tmsang.domain.R_Driver", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_DriverBike", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.B_OrderPaymentCreditCard", b =>
                {
                    b.HasOne("tmsang.domain.R_OrderPayment", null)
                        .WithOne()
                        .HasForeignKey("tmsang.domain.B_OrderPaymentCreditCard", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("tmsang.domain.R_Guest", b =>
                {
                    b.Navigation("OrderRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
