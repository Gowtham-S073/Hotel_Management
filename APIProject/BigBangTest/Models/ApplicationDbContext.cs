using Microsoft.EntityFrameworkCore;

namespace BigBangTest.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Motel> Motel { get; set; }

        public DbSet<Room> Room { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Admin> Admin { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
    }
}

