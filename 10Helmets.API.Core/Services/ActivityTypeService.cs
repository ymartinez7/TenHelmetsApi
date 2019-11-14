namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ActivityTypeService : BaseService<ActivityType>, IActivityTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="activityTypeRepository"></param>
        public ActivityTypeService(IActivityTypeRepository activityTypeRepository)
            : base(activityTypeRepository)
        {

        }
    }
}
