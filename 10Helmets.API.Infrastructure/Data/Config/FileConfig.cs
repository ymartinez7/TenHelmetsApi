namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class FileConfig : IEntityTypeConfiguration<File>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
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
