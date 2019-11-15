namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProviderConfig : IEntityTypeConfiguration<Provider>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Rif).IsRequired().HasMaxLength(10);
            builder.Property(p => p.TaxAddress).IsRequired().HasMaxLength(200);
            builder.Property(p => p.LocalNumber);

            builder.HasOne(p => p.Sector).WithMany().HasForeignKey(p => p.SectorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
