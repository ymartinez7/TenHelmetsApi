namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class EventLog : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int EventLogTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual EventLogType EventLogType { get; set; }
    }
}
