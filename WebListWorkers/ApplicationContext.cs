using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebListWorkers.Models;

namespace WebListWorkers
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Worker> Workers { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
      
    }
}
