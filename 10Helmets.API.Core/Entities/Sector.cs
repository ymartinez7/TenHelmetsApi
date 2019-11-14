namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Sector : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Sector()
        {
            this.Providers = new HashSet<Provider>();
            this.Customers = new HashSet<Customer>();
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
        public virtual IEnumerable<Provider> Providers { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Customer> Customers { get; private set; }
    }
}
