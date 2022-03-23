using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class ResourceConfig : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(200);
            builder.Property(p => p.SerialNumber);
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.UnitaryPrice).IsRequired();
            builder.Property(p => p.State);

            builder.HasOne(p => p.ResourceType).WithMany().HasForeignKey(p => p.ResourceTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Brand).WithMany().HasForeignKey(p => p.BrandId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
