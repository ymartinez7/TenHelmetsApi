namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceTypeRepository : BaseRepository<ResourceType>, IResourceTypeRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public ResourceTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
