using APICoreBank.Models.Entities;
using APICoreBank.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace APICoreBank.Models.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<UserCardInfo> CardInfoes { get; set; }
    }
}
