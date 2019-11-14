namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class InspectionType : Base
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
