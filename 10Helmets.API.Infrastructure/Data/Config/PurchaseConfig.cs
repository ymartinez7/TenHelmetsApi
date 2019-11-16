namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PurchaseConfig : IEntityTypeConfiguration<Purchase>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DeliveryDate).IsRequired();
            builder.Property(p => p.TotalAmount).IsRequired();

            builder.HasOne(p => p.Request).WithMany().HasForeignKey(p => p.RequestId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Provider).WithMany().HasForeignKey(p => p.ProviderId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PaymentType).WithMany().HasForeignKey(p => p.PaymentTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
