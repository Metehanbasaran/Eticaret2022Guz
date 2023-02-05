using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class CommetMap : IEntityTypeConfiguration<Commet>
    {
        public void Configure(EntityTypeBuilder<Commet> builder)
        {


            builder.Property(x => x.commentingperson).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.CommetSurName).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.CommetText).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.CommetStatu).HasDefaultValue(true);
            builder.Property(x => x.CommetDateTime).HasColumnName("datetime");


            builder.HasData(new Commet
            {
                CommetId = 1,
                CommetStatu = true,
                commentingperson = "Ahmet",
                CommetSurName ="Kalmış",CommetDateTime =Convert.ToDateTime("2002-01-01"),
                CommetText="Güzelllmişşş",
                
            });
        }
    }
}
