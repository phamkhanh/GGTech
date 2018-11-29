using GGTech.Domain.Data.EF.Extension;
using GGTech.Domain.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGTech.Domain.Data.EF.Configuration
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            //entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            //.HasMaxLength(50).IsUnicode(false);
            // etc.
        }
    }
}