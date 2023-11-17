using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Suggetion> Suggetions{ get; set; }
    }
}
