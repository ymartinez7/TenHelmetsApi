using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Rif).IsRequired().HasMaxLength(10);
            builder.Property(p => p.TaxAddress).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ContactEmployeeFirstName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ContactEmployeeLastName).IsRequired().HasMaxLength(200);
            builder.Property(p => p.PhoneNumber);

            builder.HasOne(p => p.Sector).WithMany(p => p.Customers).HasForeignKey(p => p.SectorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
