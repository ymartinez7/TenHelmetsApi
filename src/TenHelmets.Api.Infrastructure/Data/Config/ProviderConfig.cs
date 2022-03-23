using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class ProviderConfig : IEntityTypeConfiguration<Provider>
    {
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
