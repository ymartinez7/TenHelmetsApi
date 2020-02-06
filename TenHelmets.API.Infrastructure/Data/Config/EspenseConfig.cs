using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class EspenseConfig : IEntityTypeConfiguration<Espense>
    {
        public void Configure(EntityTypeBuilder<Espense> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200);
            builder.Property(p => p.StartDate).IsRequired();
            builder.Property(p => p.EndDate).IsRequired();
            builder.Property(p => p.Reimbursement);
            builder.Property(p => p.ReimbursementAmount);
            builder.Property(p => p.ReimbursementDate);

            builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.EspenseType).WithMany().HasForeignKey(p => p.EspenseTypeId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(p => p.Project).WithMany().HasForeignKey(p => p.ProjectId);
            builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
