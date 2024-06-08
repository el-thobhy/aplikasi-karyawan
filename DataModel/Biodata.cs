using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aplikasi_karyawan.DataModel
{
    public class Biodata: BaseProperties
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Dob { get; set; } = default!;
        public string Pob { get; set; } = default!;
        public string Address { get; set; } = default!;
        public bool MaritalStatus { get; set; } = default!;
    }
    public class BiodataConfiguration : IEntityTypeConfiguration<Biodata>
    {
        public void Configure(EntityTypeBuilder<Biodata> builder)
        {
            builder.ToTable("Biodata");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(20);

            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(30);

            builder.Property(x => x.Dob).IsRequired();
            builder.Property(x => x.Dob).HasMaxLength(10);

            builder.Property(x => x.Pob).IsRequired();
            builder.Property(x => x.Pob).HasMaxLength(50);

            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(255);

            builder.Property(x => x.MaritalStatus).IsRequired();

            builder.Seed();
        }
    }

    public static class BiodataBuilderExtension
    {
        public static void Seed(this EntityTypeBuilder<Biodata> builder)
        {
            builder.HasData(
                new Biodata
                {
                    Id = 1,
                    FirstName = "Raya",
                    LastName = "Indriyani",
                    Dob = "1991-01-01",
                    Pob = "Bali",
                    Address = "Jl. Raya Baru, Bali",
                    MaritalStatus = false,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Biodata
                {
                    Id = 2,
                    FirstName = "Rere",
                    LastName = "Wulandari",
                    Dob = "1992-01-02",
                    Pob = "Bandung",
                    Address = "Jl. Berkah Ramadhan, Bandung",
                    MaritalStatus = false,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Biodata
                {
                    Id = 3,
                    FirstName = "Bunga",
                    LastName = "Maria",
                    Dob = "1991-03-03",
                    Pob = "Jakarta",
                    Address = "Jl. Mawar Semerbak, Bogor",
                    MaritalStatus = true,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Biodata
                {
                    Id = 4,
                    FirstName = "Natasha",
                    LastName = "Wulan",
                    Dob = "1990-04-10",
                    Pob = "Jakarta",
                    Address = "Jl. Mawar Harum, Jakarta",
                    MaritalStatus = false,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Biodata
                {
                    Id = 5,
                    FirstName = "Zahra",
                    LastName = "Aurelia Putri",
                    Dob = "1991-03-03",
                    Pob = "Jakarta",
                    Address = "Jl. Mawar Semerbak, Bogor",
                    MaritalStatus = true,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                },
                new Biodata
                {
                    Id = 6,
                    FirstName = "Katniss",
                    LastName = "Everdeen",
                    Dob = "1989-01-12",
                    Pob = "Jakarta",
                    Address = "Jl. Bunga Melati, Jakarta",
                    MaritalStatus = true,
                    CreateBy = "admin",
                    CreateDate = DateTime.Now
                }
                );
        }
    }


}
