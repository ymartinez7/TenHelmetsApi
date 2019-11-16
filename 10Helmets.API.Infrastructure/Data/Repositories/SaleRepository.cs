namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public SaleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
