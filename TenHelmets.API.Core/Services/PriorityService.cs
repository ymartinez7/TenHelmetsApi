using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class PriorityService : BaseService<Priority>, IPriorityService
    {
        public PriorityService(IPriorityRepository priorityRepository)
            : base(priorityRepository)
        {

        }
    }
}
