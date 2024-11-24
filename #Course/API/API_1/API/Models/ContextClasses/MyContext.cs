using API.Extensions;
using API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;

namespace API.Models.ContextClasses
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt ):base(opt) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddCategoryData();
        }

        public DbSet<Category>Categories { get; set; }
    }
}
