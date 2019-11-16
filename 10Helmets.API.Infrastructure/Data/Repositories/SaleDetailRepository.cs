namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SaleDetailRepository : BaseRepository<SaleDetail>, ISaleDetailRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public SaleDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
