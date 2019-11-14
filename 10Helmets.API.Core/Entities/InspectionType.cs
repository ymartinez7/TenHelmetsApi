namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class InspectionType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public InspectionType()
        {
            this.Inspections = new HashSet<Inspection>();
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
        public virtual IEnumerable<Inspection> Inspections { get; private set; }
    }
}
