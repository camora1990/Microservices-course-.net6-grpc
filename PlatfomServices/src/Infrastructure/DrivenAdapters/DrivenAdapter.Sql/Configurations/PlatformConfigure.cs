using Domain.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivenAdapter.Sql.Configurations
{
    public class PlatformConfigure : IEntityTypeConfiguration<Platform>
    {
        public void Configure(EntityTypeBuilder<Platform> builder)
        {
            builder.ToTable(nameof(Platform));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Cost).IsRequired();
            builder.Property(x => x.Publisher).IsRequired();
            builder.Property(x => x.CreateAt).HasDefaultValue(DateTime.UtcNow);
        }
    }
}