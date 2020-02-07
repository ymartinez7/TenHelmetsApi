using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class AlertConfig : IEntityTypeConfiguration<Alert>
    {
        public void Configure(EntityTypeBuilder<Alert> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Warning);
            builder.Property(p => p.Critical);

            builder.HasOne(p => p.AlertType).WithMany().HasForeignKey(p => p.AlertTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Activity).WithMany().HasForeignKey(p => p.ActivityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Request).WithMany().HasForeignKey(p => p.RequestId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ProjectBudget).WithMany().HasForeignKey(p => p.ProjectBudgetId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
