﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleServiceManagement.Models;

#nullable disable

namespace managesystem.Migrations
{
    [DbContext(typeof(VehicleServiceManagementContext))]
    partial class VehicleServiceManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VehicleServiceManagement.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CustomerId")
                        .HasName("PK__Customer__A4AE64D87E24C61B");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.MaterialBill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Bill_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SrId")
                        .HasColumnType("int")
                        .HasColumnName("SR_ID");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.HasKey("BillId")
                        .HasName("PK__Material__CF6E7DA32F8BFC6B");

                    b.HasIndex("SrId");

                    b.ToTable("MaterialBill", (string)null);
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.ServiceRecord", b =>
                {
                    b.Property<int>("SrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SR_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SrId"));

                    b.Property<DateTime>("DateOfService")
                        .HasColumnType("date");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<decimal>("ServiceCost")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("ServiceDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasColumnName("VehicleID");

                    b.HasKey("SrId")
                        .HasName("PK__ServiceR__1D8D10010CEF26D7");

                    b.HasIndex("ID");

                    b.HasIndex("VehicleId");

                    b.ToTable("ServiceRecord", (string)null);
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2023, 11, 1, 13, 28, 12, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            FirstName = "Admin",
                            LastName = "",
                            MobileNumber = "1234567890",
                            Password = "admin1999",
                            UserType = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            AccountStatus = "ACTIVE",
                            CreatedOn = new DateTime(2023, 11, 1, 13, 28, 12, 0, DateTimeKind.Unspecified),
                            Email = "sa@gmail.com",
                            FirstName = "service adviser",
                            LastName = "",
                            MobileNumber = "1234567892",
                            Password = "sa1999",
                            UserType = "SERVICE_ADVISER"
                        });
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Vin")
                        .IsRequired()
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)")
                        .HasColumnName("VIN");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("VehicleId")
                        .HasName("PK__Vehicle__476B5492E1BB7978");

                    b.HasIndex("CustomerId");

                    b.HasIndex(new[] { "Vin" }, "UQ__Vehicle__C5DF234CB1459B78")
                        .IsUnique();

                    b.ToTable("Vehicle", (string)null);
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.MaterialBill", b =>
                {
                    b.HasOne("VehicleServiceManagement.Models.ServiceRecord", "Sr")
                        .WithMany("MaterialBills")
                        .HasForeignKey("SrId")
                        .IsRequired()
                        .HasConstraintName("FK__MaterialB__SR_ID__49C3F6B7");

                    b.Navigation("Sr");
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.ServiceRecord", b =>
                {
                    b.HasOne("VehicleServiceManagement.Models.User", "User")
                        .WithMany("ServiceRecords")
                        .HasForeignKey("ID")
                        .IsRequired()
                        .HasConstraintName("FK__ServiceRe__UserI__46E78A0C");

                    b.HasOne("VehicleServiceManagement.Models.Vehicle", "Vehicle")
                        .WithMany("ServiceRecords")
                        .HasForeignKey("VehicleId")
                        .IsRequired()
                        .HasConstraintName("FK__ServiceRe__Vehic__45F365D3");

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.Vehicle", b =>
                {
                    b.HasOne("VehicleServiceManagement.Models.Customer", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK__Vehicle__Custome__4316F928");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.Customer", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.ServiceRecord", b =>
                {
                    b.Navigation("MaterialBills");
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.User", b =>
                {
                    b.Navigation("ServiceRecords");
                });

            modelBuilder.Entity("VehicleServiceManagement.Models.Vehicle", b =>
                {
                    b.Navigation("ServiceRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
