using GGTech.Domain.Data.EF.Extension;
using GGTech.Domain.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGTech.Domain.Data.EF.Configuration
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            //entity.Property(c => c.Id).HasMaxLength(50)
            //    .IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }
}