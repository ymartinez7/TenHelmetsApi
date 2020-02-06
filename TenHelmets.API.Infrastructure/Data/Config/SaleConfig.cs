using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class SaleConfig : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.TotalAmount).IsRequired();

            builder.HasOne(p => p.Customer).WithMany().HasForeignKey(p => p.CustomerId);
            builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId);
            builder.HasOne(p => p.PaymentType).WithMany().HasForeignKey(p => p.PaymentTypeId);
        }
    }
}
