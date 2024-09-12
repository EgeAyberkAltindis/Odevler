using Bilgisayar_Dal.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar_Dal.Confugurations
{
    public class BilgisayarConfugurations : IEntityTypeConfiguration<Bilgisayar>
    {
        public void Configure(EntityTypeBuilder<Bilgisayar> builder)
        {
            builder.HasOne(x=>x.Anakart).WithMany(x => x.Bilgisayars)
                .HasForeignKey(x => x.AnakartId);
            builder.Property(x => x.AnakartId).HasColumnName("AnakartID");
               
            builder.HasOne(x => x.EkranKartı).WithMany(x => x.Bilgisayars)
                .HasForeignKey(x => x.EkranKartıId);
            builder.Property(x => x.EkranKartıId).HasColumnName("EkranKartıID");


            builder.HasOne(x => x.Islemci).WithMany(x => x.Bilgisayars)
                .HasForeignKey(x => x.IslemciId);
            builder.Property(x => x.IslemciId).HasColumnName("IslemciID");


            builder.HasOne(x => x.Marka).WithMany(x => x.Bilgisayars)
                .HasForeignKey(x => x.MarkaId);
            builder.Property(x => x.MarkaId).HasColumnName("MarkaID");


            builder.HasOne(x => x.Model).WithMany(x => x.Bilgisayars)
                .HasForeignKey(x => x.ModelId);
            builder.Property(x => x.ModelId).HasColumnName("ModelID");


            builder.HasOne(x => x.Ram).WithMany(x => x.Bilgisayars)
                .HasForeignKey(x => x.RamId);
            builder.Property(x => x.RamId).HasColumnName("RamID");




        }
    }
}
