using Microsoft.EntityFrameworkCore;
using WebApplicationSheCare.Models;

namespace WebApplicationSheCare.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
