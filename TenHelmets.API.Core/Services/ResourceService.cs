using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ResourceService : BaseService<Resource>, IResourceService
    {
        public ResourceService(IResourceRepository resourceRepository)
            : base(resourceRepository)
        {

        }
    }
}
