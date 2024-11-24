using DAL.Confuguraitons;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MODEL.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ProjectContext:IdentityDbContext<User,IdentityRole<int>,int>
    {
        //public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        //{

        //}
        //public ProjectContext()
        //{

        //}

        public DbSet<Bilgisayar> Bilgisayars { get; set; }
        public DbSet<BilgisayarCategory>BilgisayarCategories { get; set; }
        public DbSet<EkranKartı> EkranKarts { get; set; }
        public DbSet<Islemci>Islemcis { get; set; }
        public DbSet<Ekran> Ekrans {  get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail>OrderDetails { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<User> Users { get; set; }










        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=KDK-404-PCO4-YZ;database=BilgisayarToplamaDB;Trusted_Connection=True;TrustServerCertificate=True");
                    //"server=DESKTOP-ABTB3OG\\SQLEXPRESS;database=BilgisayarToplamaDB;Trusted_Connection=True;TrustServerCertificate=True");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new OrderConfugurations());

            builder.ApplyConfiguration(new BilgisayarConfugurations());

            base.OnModelCreating(builder);
        }
    }
}
