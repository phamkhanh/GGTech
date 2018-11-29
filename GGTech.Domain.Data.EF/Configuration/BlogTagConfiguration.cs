using GGTech.Domain.Data.EF.Extension;
using GGTech.Domain.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGTech.Domain.Data.EF.Configuration
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            //entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            //.IsUnicode(false).HasMaxLength(50);
            // etc.
        }
    }
}