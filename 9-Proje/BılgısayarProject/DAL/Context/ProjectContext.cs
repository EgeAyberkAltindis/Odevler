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
    public class ProjectContext:IdentityDbContext
    {
        //public ProjectContext(DbContextOptions<ProjectContext> options): base(options)
        //{
            
        //}
        //public ProjectContext()
        //{
                
        //}

        DbSet<Bilgisayar> Bilgisayars { get; set; }
        DbSet<BilgisayarCategory>BilgisayarCategories { get; set; }
        DbSet<EkranKartı> EkranKarts { get; set; }
        DbSet<Islemci>Islemcis { get; set; }
        DbSet<Ekran> Ekrans {  get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail>OrderDetails { get; set; }
        DbSet<Ram> Rams { get; set; }

        








        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=DESKTOP-ABTB3OG\\SQLEXPRESS;database=BilgisayarToplamaDB;Trusted_Connection=True;TrustServerCertificate=True");
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
