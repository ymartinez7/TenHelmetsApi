using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Infrastructure.Data.Context;

namespace TenHelmets.API.Infrastructure.Data.Repositories
{
    public sealed class ResourceTypeRepository : BaseRepository<ResourceType>, IResourceTypeRepository
    {
        public ResourceTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
