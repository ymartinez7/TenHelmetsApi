using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class RolService : BaseService<Rol>, IRolService
    {
        public RolService(IRolRepository rolRepository)
            : base(rolRepository)
        {

        }
    }
}
