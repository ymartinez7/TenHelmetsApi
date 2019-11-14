namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Model : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Model()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Capacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Measure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }
    }
}
