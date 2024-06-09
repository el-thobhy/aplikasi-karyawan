using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aplikasi_karyawan.DataModel
{
    public class Employee : BaseProperties
    {
        public int Id { get; set; }
        public int BiodataId { get; set; }
        public string? Nip { get; set; } = default!;
        public string? Status { get; set; } = default!;
        public double Salary { get; set; } = default!;

        [ForeignKey("BiodataId")]
        public virtual Biodata Biodata { get; set; }
    }

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            
            builder.Property(e => e.BiodataId).IsRequired();
            
            builder.Property(e => e.Nip).IsRequired();
            builder.Property(e => e.Nip).HasMaxLength(5);

            builder.Property(e => e.Status).IsRequired();
            builder.Property(e => e.Status).HasMaxLength(10);

            builder.Property(e => e.Salary).IsRequired();
            builder.Property(e=>e.Salary).HasPrecision(10,0);

            builder.Seed();
        }
    }

    public static class EmployeeBuilderExtension
    {
        public static void Seed(this EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    BiodataId = 1,
                    Nip = "NX001",
                    Status = "Permanen",
                    Salary = 12000000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Employee
                {
                    Id = 2,
                    BiodataId = 2,
                    Nip = "NX002",
                    Status = "Kontrak",
                    Salary = 15000000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Employee
                {
                    Id = 3,
                    BiodataId = 4,
                    Nip = "NX003",
                    Status = "Permanen",
                    Salary = 13500000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Employee
                {
                    Id = 4,
                    BiodataId = 5,
                    Nip = "NX004",
                    Status = "Permanen",
                    Salary = 12000000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Employee
                {
                    Id = 5,
                    BiodataId = 6,
                    Nip = "NX005",
                    Status = "Permanen",
                    Salary = 17000000,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                }
                );
        }
    }
}
