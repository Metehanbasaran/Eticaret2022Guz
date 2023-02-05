using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class SubCategoryMap: IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {


            builder.Property(x => x.SortKey).HasDefaultValue(0);
            builder.Property(x => x.SubCategoryStatu).HasDefaultValue(true);
            builder.Property(x => x.SubCategoryName).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.CategoryId).HasColumnType("int");

            builder.HasData(new SubCategory
            {
                SubCategoryId = 1,
                SubCategoryStatu = true,
                SubCategoryName = "Bilgisayar",
                SortKey = 1
            });
        }
    }
}
