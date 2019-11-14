namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class EventLogType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public EventLogType()
        {
            this.EventLogs = new HashSet<EventLog>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<EventLog> EventLogs { get; private set; }
    }
}
