using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ActivityTypeService : BaseService<ActivityType>, IActivityTypeService
    {
        public ActivityTypeService(IActivityTypeRepository activityTypeRepository)
            : base(activityTypeRepository)
        {

        }
    }
}
