namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
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
