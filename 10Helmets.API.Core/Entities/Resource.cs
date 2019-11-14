namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Resource : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Resource()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
            this.Models = new HashSet<Model>();
            this.ResourceRequests = new HashSet<ResourceRequest>();
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
        public int ResourceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal UnitaryPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ResourceType ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Brand Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Model> Models { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ResourceRequest> ResourceRequests { get; private set; }
    }
}
