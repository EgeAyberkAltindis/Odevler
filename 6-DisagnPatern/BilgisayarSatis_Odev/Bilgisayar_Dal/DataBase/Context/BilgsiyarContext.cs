using Bilgisayar_Dal.Confugurations;
using Bilgisayar_Dal.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.DataBase.Context
{
    public class BilgsiyarContext:DbContext
    {
        public DbSet<Anakart> Anakarts {  get; set; }
        public DbSet<EkranKartı> EkranKarts {  get; set; }
        public DbSet<Islemci> Islemcis { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Ram> Rams{ get; set; }
       
        public DbSet<Bilgisayar>Bilgisayars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("server=DESKTOP-ABTB3OG\\SQLEXPRESS;database=BilgisayarSatis;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AnakartConfigurations());
            modelBuilder.ApplyConfiguration(new BilgisayarConfugurations());
            modelBuilder.ApplyConfiguration(new EkranKartıConfigurations());
            modelBuilder.ApplyConfiguration(new IslemciConfigurations ());
            modelBuilder.ApplyConfiguration(new MarkaConfugrutaions());
            modelBuilder.ApplyConfiguration(new ModelsConfuguraitosn());
            modelBuilder.ApplyConfiguration(new RamConfugurations());



            base.OnModelCreating(modelBuilder);
        }

    }
}
