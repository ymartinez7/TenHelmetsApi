using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ResourceTypeService : BaseService<ResourceType>, IResourceTypeService
    {
        public ResourceTypeService(IResourceTypeRepository resourceTypeRepository)
            : base(resourceTypeRepository)
        {

        }
    }
}
