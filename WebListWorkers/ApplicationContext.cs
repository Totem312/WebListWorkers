using System.Collections.Generic;
using WebListWorkers.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;


namespace WebListWorkers
{
    public class ApplicationContext:DbContext
    {

        public DbSet<Worker> Workers { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.Migrate();
        }
    }
}
