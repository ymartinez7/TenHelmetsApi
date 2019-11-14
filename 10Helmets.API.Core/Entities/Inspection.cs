namespace _10Helmets.API.Core.Entities
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Inspection : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int InspectionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Activity Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual InspectionType InspectionType { get; set; }
    }
}
