namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class ActivityType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// /
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Activity> Activity { get; private set; }
    }
}
