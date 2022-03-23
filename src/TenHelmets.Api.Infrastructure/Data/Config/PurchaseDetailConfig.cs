using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class PurchaseDetailConfig : IEntityTypeConfiguration<PurchaseDetail>
    {
        public void Configure(EntityTypeBuilder<PurchaseDetail> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Item).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Brand).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Model).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.UnitPrice).IsRequired();

            builder.HasOne(p => p.Purchase).WithMany().HasForeignKey(p => p.PurchaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
