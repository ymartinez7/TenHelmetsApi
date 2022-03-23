using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class ProviderService : BaseService<Provider>, IProviderService
    {
        public ProviderService(IProviderRepository providerRepository)
            : base(providerRepository)
        {

        }
    }
}
