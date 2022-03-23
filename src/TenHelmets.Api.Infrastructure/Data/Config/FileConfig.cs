using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class FileConfig : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Size).IsRequired();
            builder.Property(p => p.Extension).IsRequired().HasMaxLength(3);

            builder.HasOne(p => p.ServiceOrder).WithMany().HasForeignKey(p => p.ServiceOrderId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
