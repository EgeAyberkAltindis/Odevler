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
    public class MarkaConfugrutaions : IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> builder)
        {
            builder.Property(x => x.Fiyat).HasColumnType("money").HasColumnName("decimal");
        }
    }
}
