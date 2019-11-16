namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ModelConfig : IEntityTypeConfiguration<Model>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Year);
            builder.Property(p => p.Capacity);
            builder.Property(p => p.Measure);

            builder.HasOne(p => p.Resource).WithMany().HasForeignKey(p => p.ResourceId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
