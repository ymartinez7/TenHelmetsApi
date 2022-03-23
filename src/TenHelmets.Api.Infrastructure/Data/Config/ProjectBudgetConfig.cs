using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class ProjectBudgetConfig : IEntityTypeConfiguration<ProjectBudget>
    {
        public void Configure(EntityTypeBuilder<ProjectBudget> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.ApprovalDate).IsRequired();

            builder.HasOne(p => p.Unit).WithMany().HasForeignKey(p => p.UnitId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Project).WithMany().HasForeignKey(p => p.ProjectId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
