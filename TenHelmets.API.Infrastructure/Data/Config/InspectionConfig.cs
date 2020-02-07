using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class InspectionConfig : IEntityTypeConfiguration<Inspection>
    {
        public void Configure(EntityTypeBuilder<Inspection> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Date).IsRequired();

            builder.HasOne(p => p.Activity).WithMany().HasForeignKey(p => p.ActivityId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.InspectionType).WithMany().HasForeignKey(p => p.InspectionTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
