﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aplikasi_karyawan.DataModel;

#nullable disable

namespace aplikasi_karyawan.Migrations
{
    [DbContext(typeof(KaryawanDbContext))]
    partial class KaryawanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("aplikasi_karyawan.DataModel.Biodata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dob")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("MaritalStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pob")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Biodata", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Jl. Raya Baru, Bali",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6938),
                            Dob = "1991-01-01",
                            FirstName = "Raya",
                            IsDeleted = false,
                            LastName = "Indriyani",
                            MaritalStatus = false,
                            Pob = "Bali"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Jl. Berkah Ramadhan, Bandung",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6943),
                            Dob = "1992-01-02",
                            FirstName = "Rere",
                            IsDeleted = false,
                            LastName = "Wulandari",
                            MaritalStatus = false,
                            Pob = "Bandung"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Jl. Mawar Semerbak, Bogor",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6945),
                            Dob = "1991-03-03",
                            FirstName = "Bunga",
                            IsDeleted = false,
                            LastName = "Maria",
                            MaritalStatus = true,
                            Pob = "Jakarta"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Jl. Mawar Harum, Jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6947),
                            Dob = "1990-04-10",
                            FirstName = "Natasha",
                            IsDeleted = false,
                            LastName = "Wulan",
                            MaritalStatus = false,
                            Pob = "Jakarta"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Jl. Mawar Semerbak, Bogor",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6949),
                            Dob = "1991-03-03",
                            FirstName = "Zahra",
                            IsDeleted = false,
                            LastName = "Aurelia Putri",
                            MaritalStatus = true,
                            Pob = "Jakarta"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Jl. Bunga Melati, Jakarta",
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(6951),
                            Dob = "1989-01-12",
                            FirstName = "Katniss",
                            IsDeleted = false,
                            LastName = "Everdeen",
                            MaritalStatus = true,
                            Pob = "Jakarta"
                        });
                });

            modelBuilder.Entity("aplikasi_karyawan.DataModel.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BiodataId")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nip")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<double>("Salary")
                        .HasPrecision(10)
                        .HasColumnType("float(10)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("BiodataId");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BiodataId = 1,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4726),
                            IsDeleted = false,
                            Nip = "NX001",
                            Salary = 12000000.0,
                            Status = "Permanen"
                        },
                        new
                        {
                            Id = 2,
                            BiodataId = 2,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4739),
                            IsDeleted = false,
                            Nip = "NX002",
                            Salary = 15000000.0,
                            Status = "Kontrak"
                        },
                        new
                        {
                            Id = 3,
                            BiodataId = 4,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4741),
                            IsDeleted = false,
                            Nip = "NX003",
                            Salary = 13500000.0,
                            Status = "Permanen"
                        },
                        new
                        {
                            Id = 4,
                            BiodataId = 5,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4743),
                            IsDeleted = false,
                            Nip = "NX004",
                            Salary = 12000000.0,
                            Status = "Permanen"
                        },
                        new
                        {
                            Id = 5,
                            BiodataId = 6,
                            CreateBy = "admin",
                            CreateDate = new DateTime(2024, 6, 8, 21, 27, 58, 679, DateTimeKind.Local).AddTicks(4744),
                            IsDeleted = false,
                            Nip = "NX005",
                            Salary = 17000000.0,
                            Status = "Permanen"
                        });
                });

            modelBuilder.Entity("aplikasi_karyawan.DataModel.Employee", b =>
                {
                    b.HasOne("aplikasi_karyawan.DataModel.Biodata", "Biodata")
                        .WithMany()
                        .HasForeignKey("BiodataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Biodata");
                });
#pragma warning restore 612, 618
        }
    }
}