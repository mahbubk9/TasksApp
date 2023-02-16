
using Microsoft.EntityFrameworkCore;
using TasksApp.Models;

namespace TasksApp.Data
{
    
        public class ApplicationDBContext : DbContext
        {
            public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
            {

            }

            public DbSet<Tasks> TaskNames{ get; set; }
        }
    }

