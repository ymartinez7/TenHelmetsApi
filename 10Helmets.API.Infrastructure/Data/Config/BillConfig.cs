namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class BillConfig : IEntityTypeConfiguration<Bill>
    {
        /// <summary>
        /// 
        /// </summary>
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.Amount).IsRequired();

            builder.HasOne(p => p.Project).WithMany().HasForeignKey(p => p.ProjectId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p => p.PaymentType).WithMany().HasForeignKey(p => p.PaymentTypeId).OnDelete(DeleteBehavior.Restrict);
            //builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId);
        }
    }
}
