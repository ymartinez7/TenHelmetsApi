using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.MiddleName);
            builder.Property(p => p.FirstSureName).IsRequired();
            builder.Property(p => p.SecondSureName);
            builder.Property(p => p.Document).IsRequired().HasMaxLength(10);
            builder.Property(p => p.PhoneNumber);

            builder.HasOne(p => p.DocumentType).WithMany().HasForeignKey(p => p.DocumentTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Rol).WithMany().HasForeignKey(p => p.RolId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
