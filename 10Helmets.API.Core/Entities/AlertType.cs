namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class AlertType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public AlertType()
        {
            this.Alerts = new HashSet<Alert>();
            this.Activities = new HashSet<Activity>();
            this.Priorities = new HashSet<Priority>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Alert> Alerts { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Activity> Activities { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Priority> Priorities { get; private set; }
    }
}
