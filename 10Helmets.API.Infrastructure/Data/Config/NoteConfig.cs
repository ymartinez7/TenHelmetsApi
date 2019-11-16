namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class NoteConfig : IEntityTypeConfiguration<Note>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Content).IsRequired().HasMaxLength(500);

            builder.HasOne(p => p.Activity).WithMany().HasForeignKey(p => p.ActivityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
