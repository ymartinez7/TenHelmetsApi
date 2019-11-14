namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ActivityService : BaseService<Activity>, IActivityService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="activityRepository"></param>
        public ActivityService(IActivityRepository activityRepository)
            : base(activityRepository)
        {

        }
    }
}
