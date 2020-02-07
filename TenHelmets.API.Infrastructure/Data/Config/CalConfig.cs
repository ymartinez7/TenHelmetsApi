using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class CalConfig : IEntityTypeConfiguration<Cal>
    {
        public void Configure(EntityTypeBuilder<Cal> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DetectionDate).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Analysis).IsRequired().HasMaxLength(500);
            builder.Property(p => p.CorrectionDate);
            builder.Property(p => p.CorrectionResult).HasMaxLength(200);

            builder.HasOne(p => p.Activity).WithMany().HasForeignKey(p => p.ActivityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.ActionType).WithMany().HasForeignKey(p => p.ActionTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
