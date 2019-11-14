namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ResourceTypeService : BaseService<ResourceType>, IResourceTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resourceTypeRepository"></param>
        public ResourceTypeService(IResourceTypeRepository resourceTypeRepository)
            : base(resourceTypeRepository)
        {

        }
    }
}
