using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}
