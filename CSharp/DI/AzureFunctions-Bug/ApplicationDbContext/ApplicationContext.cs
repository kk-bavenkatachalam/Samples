using Microsoft.EntityFrameworkCore;

namespace ApplicationDbContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(string connectionString) : this(new DbContextOptionsBuilder<ApplicationContext>().UseSqlServer(connectionString).Options)
        {
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> connectionOptions) : base(connectionOptions)
        {
        }
    }
}


