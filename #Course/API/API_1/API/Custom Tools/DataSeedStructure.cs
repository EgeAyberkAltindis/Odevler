using API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Custom_Tools
{
    public static class DataSeedStructure
    {
        public static void AddCategory(ModelBuilder modelBuilder)
        {
            Category c = new Category()
            {
                ID=1,
                CategoryName = "Tatlılar",
                Description = "Deneme Verisidir"
            };
            modelBuilder.Entity<Category>().HasData(c);
        }
    }
}
