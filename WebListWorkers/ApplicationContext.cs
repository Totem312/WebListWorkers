using System.Collections.Generic;
using WebListWorkers.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;


namespace WebListWorkers
{
    /// <summary>
    /// Класс контекста базы данных
    /// </summary>
    public class ApplicationContext:DbContext
    {

        public DbSet<Worker> Workers { get; set; } = null!;
        /// <summary>
        /// Конструктор вызывающий миграции для внесение тестовых данных
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.Migrate();
        }
    }
}
