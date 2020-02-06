using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ResourceTypeId { get; set; }
        public int BrandId { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public decimal UnitaryPrice { get; set; }
        public string State { get; set; }
        public virtual ResourceType ResourceType { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }
        public virtual IEnumerable<Model> Models { get; private set; }
        public virtual IEnumerable<ResourceRequest> ResourceRequests { get; private set; }

        public Resource()
        {
            SaleDetails = new HashSet<SaleDetail>();
            Models = new HashSet<Model>();
            ResourceRequests = new HashSet<ResourceRequest>();
        }
    }
}
