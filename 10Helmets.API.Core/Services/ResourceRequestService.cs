namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceRequestService : BaseService<ResourceRequest>, IResourceRequestService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceRequestRepository"></param>
        public ResourceRequestService(IResourceRequestRepository resourceRequestRepository)
            : base(resourceRequestRepository)
        {

        }
    }
}
