using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Infrastructure.Data.Context;

namespace TenHelmets.API.Infrastructure.Data.Repositories
{
    public sealed class ModelRepository : BaseRepository<Model>, IModelRepository
    {
        public ModelRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
