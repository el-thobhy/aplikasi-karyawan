using Microsoft.EntityFrameworkCore;

namespace aplikasi_karyawan.DataModel
{
    public class KaryawanDbContext: DbContext
    {
        public KaryawanDbContext(DbContextOptions<KaryawanDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Biodata> Biodatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new BiodataConfiguration());
        }

        public static DbContextOptions<KaryawanDbContext> OnConfigured()
        {
            var optionBuilder = new DbContextOptionsBuilder<KaryawanDbContext>();
            optionBuilder.UseSqlServer(ServiceExtention.Configuration.GetConnectionString("DB_Conn"))
                .LogTo(Console.WriteLine);
            return optionBuilder.Options;
        }
    }

}
