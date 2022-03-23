using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class ResourceRequestConfig : IEntityTypeConfiguration<ResourceRequest>
    {
        public void Configure(EntityTypeBuilder<ResourceRequest> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantity).IsRequired();

            builder.HasOne(p => p.Request).WithMany().HasForeignKey(p => p.RequestsId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Resource).WithMany().HasForeignKey(p => p.ResourceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
