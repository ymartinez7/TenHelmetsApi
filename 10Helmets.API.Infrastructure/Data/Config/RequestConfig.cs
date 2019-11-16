namespace _10Helmets.API.Infrastructure.Data.Config
{
    using _10Helmets.API.Core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RequestConfig : IEntityTypeConfiguration<Request>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description).IsRequired().HasMaxLength(500);
            builder.Property(p => p.RequiredDate).IsRequired();
            builder.Property(p => p.Accomplish);
            builder.Property(p => p.EndDate); ;

            builder.HasOne(p => p.RequestType).WithMany().HasForeignKey(p => p.RequestTypeId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(p => p.Project).WithMany().HasForeignKey(p => p.ProjectId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(p => p.Employee).WithMany().HasForeignKey(p => p.EmployeeId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(p => p.Priority).WithMany().HasForeignKey(p => p.PriorityId).OnDelete(DeleteBehavior.Restrict); ;
            builder.HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId).OnDelete(DeleteBehavior.Restrict); ;
        }
    }
}
