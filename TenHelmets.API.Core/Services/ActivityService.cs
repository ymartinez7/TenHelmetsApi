using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ActivityService : BaseService<Activity>, IActivityService
    {
        public ActivityService(IActivityRepository activityRepository)
            : base(activityRepository)
        {

        }
    }
}
