namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EventLogService : BaseService<EventLog>, IEventLogService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="eventLogRepository"></param>
        public EventLogService(IEventLogRepository eventLogRepository)
            : base(eventLogRepository)
        {

        }
    }
}
