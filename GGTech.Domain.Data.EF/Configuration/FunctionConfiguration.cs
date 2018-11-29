using GGTech.Domain.Data.EF.Extension;
using GGTech.Domain.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GGTech.Domain.Data.EF.Configuration
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            //entity.HasKey(c => c.Id);
            //entity.Property(c => c.Id).IsRequired()
            //    .HasMaxLength(128).IsUnicode(false);
            // etc.
        }
    }
}