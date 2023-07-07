using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BigBangTest.Auth
{
    public class AuthorizationDBContext : IdentityDbContext<IdentityUser>
    {
        public AuthorizationDBContext(DbContextOptions<AuthorizationDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}