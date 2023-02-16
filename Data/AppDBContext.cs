using Microsoft.EntityFrameworkCore;

namespace TasksApp.Data
{
    public class AppDBContext
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            public DbSet<Task> TaskNames{ get; set; }
        }
    }
}
