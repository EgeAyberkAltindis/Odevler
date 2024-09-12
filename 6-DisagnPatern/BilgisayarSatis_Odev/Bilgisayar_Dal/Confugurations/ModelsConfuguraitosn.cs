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
    public class ModelsConfuguraitosn : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.Property(x => x.Fiyat).HasColumnType("money").HasColumnName("decimal");
        }
    }
}
