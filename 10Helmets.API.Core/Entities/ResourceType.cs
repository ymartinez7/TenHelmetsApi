namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class ResourceType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public ResourceType()
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
