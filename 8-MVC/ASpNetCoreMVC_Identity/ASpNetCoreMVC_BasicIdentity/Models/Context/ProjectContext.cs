using ASpNetCoreMVC_BasicIdentity.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ASpNetCoreMVC_BasicIdentity.Models.Context
{
    public class ProjectContext:IdentityDbContext<AppUser>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {

        }

        public ProjectContext()
        {

        }


        //public DbSet<User> Users { get; set; }

        //Connectionstring

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=KDK-404-PCEG-YZ;database=IdentityFakeDB;uid=sa;pwd=123;TrustServerCertificate=True");
        //    }
        //    base.OnConfiguring(optionsBuilder);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Seed User Data
        //    List<User> users = new List<User>()
        //    {
        //        new User{ID=1,Username="admin",Password="123",Email="admin@admin.com"},
        //        new User{ID=2,Username="user",Password="123",Email="user@user.com"},

        //    };




        //    modelBuilder.Entity<User>().HasData(users);
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
