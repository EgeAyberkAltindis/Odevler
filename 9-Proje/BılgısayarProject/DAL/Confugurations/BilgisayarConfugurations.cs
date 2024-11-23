using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MODEL.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Confuguraitons
{
    public class BilgisayarConfugurations : IEntityTypeConfiguration<Bilgisayar>
    {
        public void Configure(EntityTypeBuilder<Bilgisayar> builder)
        {
            builder.HasOne(x => x.Ekran).WithMany(x => x.Bilgisayar).HasForeignKey(x => x.EkranId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasOne(x => x.EkranKartı).WithMany(x => x.Bilgisayar).HasForeignKey(x => x.EkranKartıId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasOne(x => x.Ram).WithMany(x => x.Bilgisayar).HasForeignKey(x => x.RamId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasOne(x => x.Islemci).WithMany(x => x.Bilgisayar).HasForeignKey(x => x.IslemciId).OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
