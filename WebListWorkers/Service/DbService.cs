using Microsoft.EntityFrameworkCore;

namespace WebListWorkers.Service
{
    public static class DbService
    {
        public static int MyProperty { get; set; }
        public static void AddDbService(this WebApplicationBuilder builder)
        {
            {
                string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
                builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
            }
        }
    }
}
