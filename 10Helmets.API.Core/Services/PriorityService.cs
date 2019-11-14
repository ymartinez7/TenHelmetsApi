namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class PriorityService : BaseService<Priority>, IPriorityService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="priorityRepository"></param>
        public PriorityService(IPriorityRepository priorityRepository)
            : base(priorityRepository)
        {

        }
    }
}
