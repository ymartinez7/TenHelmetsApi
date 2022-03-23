using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class PaymentTypeConfig : IEntityTypeConfiguration<PaymentType>
    {
        public void Configure(EntityTypeBuilder<PaymentType> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
        }
    }
}
