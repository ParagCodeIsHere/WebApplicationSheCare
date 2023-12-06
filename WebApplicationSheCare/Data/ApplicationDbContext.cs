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
        public DbSet<Suggetion> Suggetions { get; set; }
        //public DbSet<SelectedSuggetion> selectedSuggetions { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<SelectedSuggetion>()
        //        .HasKey(sc => new { sc.Id, sc.SuggetionId });

        //    modelBuilder.Entity<SelectedSuggetion>()
        //        .HasOne(sc => sc.User)
        //        .WithMany(c => c.selectedSuggetions)
        //        .HasForeignKey(sc => sc.Id);

        //    modelBuilder.Entity<SelectedSuggetion>()
        //        .HasOne(sc => sc.Suggetion)
        //        .WithMany(c => c.selectedSuggetions)
        //        .HasForeignKey(sc => sc.SuggetionId);
        //}

    }
}
