using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class EspenseTypeService : BaseService<EspenseType>, IEspenseTypeService
    {
        public EspenseTypeService(IEspenseTypeRepository espenseTypeRepository)
            : base(espenseTypeRepository)
        {

        }
    }
}
