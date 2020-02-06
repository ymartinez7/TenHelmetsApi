using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class OrganizationService : BaseService<Organization>, IOrganizationService
    {
        public OrganizationService(IOrganizationRepository organizationRepository)
            : base(organizationRepository)
        {

        }
    }
}
