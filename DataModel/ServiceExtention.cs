using Microsoft.EntityFrameworkCore;

namespace aplikasi_karyawan.DataModel
{
    public static class ServiceExtention
    {
        public static ConfigurationManager Configuration { get; set; }

        public static void AddDomainContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            Configuration = configuration;
            services.AddDbContext<KaryawanDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DB_Conn"));
            });
        }
    }
}
