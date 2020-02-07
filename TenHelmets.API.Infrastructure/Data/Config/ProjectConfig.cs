using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Code).IsRequired().HasMaxLength(8);
            builder.Property(p => p.StartDate);
            builder.Property(p => p.EndDate);

            builder.HasOne(p => p.ServiceOrder).WithMany().HasForeignKey(p => p.ServiceOrderId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
