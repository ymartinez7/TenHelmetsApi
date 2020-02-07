using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class EspenseService : BaseService<Espense>, IEspenseService
    {
        public EspenseService(IEspenseRepository espenseRepository)
            : base(espenseRepository)
        {

        }
    }
}
