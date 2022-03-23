using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ResourceRequestService : BaseService<ResourceRequest>, IResourceRequestService
    {
        public ResourceRequestService(IResourceRequestRepository resourceRequestRepository)
            : base(resourceRequestRepository)
        {

        }
    }
}
