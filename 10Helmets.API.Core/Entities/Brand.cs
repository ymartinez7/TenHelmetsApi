namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Brand : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Brand()
        {
            this.Resources = new HashSet<Resource>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Resource> Resources { get; private set; }
    }
}
