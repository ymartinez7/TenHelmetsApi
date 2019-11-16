namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ServiceOrderConfig : IEntityTypeConfiguration<ServiceOrder>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ServiceOrder> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.ReceptionDate).IsRequired();

            builder.HasOne(p => p.Customer).WithMany().HasForeignKey(p => p.CustomerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.Unit).WithMany().HasForeignKey(p => p.UnitId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
