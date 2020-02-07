using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Infrastructure.Data.Context;

namespace TenHelmets.API.Infrastructure.Data.Repositories
{
    public sealed class InspectionTypeRepository : BaseRepository<InspectionType>, IInspectionTypeRepository
    {
        public InspectionTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
