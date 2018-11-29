using GGTech.Domain.Data.EF.Extension;
using GGTech.Domain.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGTech.Domain.Data.EF.Configuration
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            //entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}