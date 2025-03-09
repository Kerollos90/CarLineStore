﻿// <auto-generated />
using System;
using CarLine.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarLine.Model.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20241206034715_changeColumnYearToShortDataType")]
    partial class changeColumnYearToShortDataType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarBrandMaintenanceCenter", b =>
                {
                    b.Property<int>("CarSpecialzedBrandId")
                        .HasColumnType("int");

                    b.Property<int>("MaintenanceCentersId")
                        .HasColumnType("int");

                    b.HasKey("CarSpecialzedBrandId", "MaintenanceCentersId");

                    b.HasIndex("MaintenanceCentersId");

                    b.ToTable("CarBrandMaintenanceCenter");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarShowRoomId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarShowRoomId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CarLine.Model.Entity.AppSeller", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CarLine.Model.Entity.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppSellerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CarShowRoomId")
                        .HasColumnType("int");

                    b.Property<int>("CarStatus")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Financed")
                        .HasColumnType("bit");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Millage")
                        .HasColumnType("int");

                    b.Property<decimal?>("MinimumDeposit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("MinimumInstallment")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Taxi")
                        .HasColumnType("bit");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Year")
                        .HasColumnType("smallint");

                    b.Property<int>("carPayment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppSellerId");

                    b.HasIndex("CarShowRoomId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarLine.Model.Entity.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("CarLine.Model.Entity.CarShowRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppSellerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DealerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DealerType")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppSellerId");

                    b.ToTable("CarShowRooms");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("CarLine.Model.Entity.MaintenanceCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("AppSellerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PictureUrlId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("AppSellerId");

                    b.HasIndex("PictureUrlId");

                    b.ToTable("MaintenanceCenters");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppSellerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CarShowRoomId")
                        .HasColumnType("int");

                    b.Property<int?>("MaintenanceCenterId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WanchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppSellerId");

                    b.HasIndex("CarShowRoomId");

                    b.HasIndex("MaintenanceCenterId");

                    b.HasIndex("WanchId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarBrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<int?>("CarShowRoomId")
                        .HasColumnType("int");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WanchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.HasIndex("CarId");

                    b.HasIndex("CarShowRoomId");

                    b.HasIndex("WanchId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Wanch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AppSellerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppSellerId");

                    b.ToTable("Wanches");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CarBrandMaintenanceCenter", b =>
                {
                    b.HasOne("CarLine.Model.Entity.CarBrand", null)
                        .WithMany()
                        .HasForeignKey("CarSpecialzedBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarLine.Model.Entity.MaintenanceCenter", null)
                        .WithMany()
                        .HasForeignKey("MaintenanceCentersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarLine.Model.Entity.Address", b =>
                {
                    b.HasOne("CarLine.Model.Entity.CarShowRoom", null)
                        .WithMany("Address")
                        .HasForeignKey("CarShowRoomId");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Car", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", null)
                        .WithMany("Car")
                        .HasForeignKey("AppSellerId");

                    b.HasOne("CarLine.Model.Entity.CarShowRoom", null)
                        .WithMany("Car")
                        .HasForeignKey("CarShowRoomId");
                });

            modelBuilder.Entity("CarLine.Model.Entity.CarShowRoom", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", "AppSeller")
                        .WithMany()
                        .HasForeignKey("AppSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppSeller");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Equipment", b =>
                {
                    b.HasOne("CarLine.Model.Entity.Car", null)
                        .WithMany("Equipments")
                        .HasForeignKey("CarId");
                });

            modelBuilder.Entity("CarLine.Model.Entity.MaintenanceCenter", b =>
                {
                    b.HasOne("CarLine.Model.Entity.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarLine.Model.Entity.AppSeller", "AppSeller")
                        .WithMany()
                        .HasForeignKey("AppSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarLine.Model.Entity.Picture", "PictureUrl")
                        .WithMany()
                        .HasForeignKey("PictureUrlId");

                    b.Navigation("Address");

                    b.Navigation("AppSeller");

                    b.Navigation("PictureUrl");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Phone", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", null)
                        .WithMany("Phone")
                        .HasForeignKey("AppSellerId");

                    b.HasOne("CarLine.Model.Entity.CarShowRoom", null)
                        .WithMany("Phone")
                        .HasForeignKey("CarShowRoomId");

                    b.HasOne("CarLine.Model.Entity.MaintenanceCenter", null)
                        .WithMany("Phone")
                        .HasForeignKey("MaintenanceCenterId");

                    b.HasOne("CarLine.Model.Entity.Wanch", null)
                        .WithMany("Phone")
                        .HasForeignKey("WanchId");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Picture", b =>
                {
                    b.HasOne("CarLine.Model.Entity.CarBrand", null)
                        .WithMany("Picture")
                        .HasForeignKey("CarBrandId");

                    b.HasOne("CarLine.Model.Entity.Car", null)
                        .WithMany("PictureUrl")
                        .HasForeignKey("CarId");

                    b.HasOne("CarLine.Model.Entity.CarShowRoom", null)
                        .WithMany("PictureUrl")
                        .HasForeignKey("CarShowRoomId");

                    b.HasOne("CarLine.Model.Entity.Wanch", null)
                        .WithMany("PictureUrl")
                        .HasForeignKey("WanchId");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Wanch", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", "AppSeller")
                        .WithMany()
                        .HasForeignKey("AppSellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppSeller");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarLine.Model.Entity.AppSeller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarLine.Model.Entity.AppSeller", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarLine.Model.Entity.AppSeller", b =>
                {
                    b.Navigation("Car");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Car", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("PictureUrl");
                });

            modelBuilder.Entity("CarLine.Model.Entity.CarBrand", b =>
                {
                    b.Navigation("Picture");
                });

            modelBuilder.Entity("CarLine.Model.Entity.CarShowRoom", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Car");

                    b.Navigation("Phone");

                    b.Navigation("PictureUrl");
                });

            modelBuilder.Entity("CarLine.Model.Entity.MaintenanceCenter", b =>
                {
                    b.Navigation("Phone");
                });

            modelBuilder.Entity("CarLine.Model.Entity.Wanch", b =>
                {
                    b.Navigation("Phone");

                    b.Navigation("PictureUrl");
                });
#pragma warning restore 612, 618
        }
    }
}
