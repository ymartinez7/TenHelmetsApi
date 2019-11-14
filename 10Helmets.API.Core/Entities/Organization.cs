namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Organization : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Organization()
        {
            this.Units = new HashSet<Unit>();
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
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Unit> Units { get; private set; }
    }
}
