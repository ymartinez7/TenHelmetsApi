using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class PriorityConfig : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.MaxTM).IsRequired();
            builder.Property(p => p.MinTM).IsRequired();

            builder.HasOne(p => p.AlertType).WithMany().HasForeignKey(p => p.AlertTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
