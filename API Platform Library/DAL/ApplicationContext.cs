using Microsoft.EntityFrameworkCore;

namespace API_Platform_Library.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Models.Tarot.Tarot> Tarot { get; set; }

    }
}
