using TenHelmets.API.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TenHelmets.API.Infrastructure.Data.Config
{
    public sealed class NoteConfig : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Content).IsRequired().HasMaxLength(500);

            builder.HasOne(p => p.Activity).WithMany().HasForeignKey(p => p.ActivityId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
