using API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class DataSeedExtension
    {
        public static void AddCategoryData(this ModelBuilder modelBuilder)
        {
            Category c = new Category()
            {
                ID = 1,
                CategoryName = "Tatlılar",
                Description = "Deneme Verisidir"
            };
            modelBuilder.Entity<Category>().HasData(c); 

        }
    }
}
