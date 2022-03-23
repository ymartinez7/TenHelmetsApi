using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class UnitService : BaseService<Unit>, IUnitService
    {
        public UnitService(IUnitRepository unitRepository)
            : base(unitRepository)
        {

        }
    }
}
