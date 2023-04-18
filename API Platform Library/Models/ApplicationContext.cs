using Microsoft.EntityFrameworkCore;

namespace API_Platform_Library.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Tarot.Tarot> Tarot { get; set; }

    }
}
