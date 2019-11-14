namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class OrganizationService : BaseService<Organization>, IOrganizationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationRepository"></param>
        public OrganizationService(IOrganizationRepository organizationRepository)
            : base(organizationRepository)
        {

        }
    }
}
