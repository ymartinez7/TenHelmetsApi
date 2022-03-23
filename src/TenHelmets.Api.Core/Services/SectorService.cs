using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class SectorService : BaseService<Sector>, ISectorService
    {
        public SectorService(ISectorRepository sectorRepository)
            : base(sectorRepository)
        {

        }
    }
}
