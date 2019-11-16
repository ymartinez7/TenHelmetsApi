namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RequestTypeRepository : BaseRepository<RequestType>, IRequestTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public RequestTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
