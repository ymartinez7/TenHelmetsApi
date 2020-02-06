namespace TenHelmets.API.Core.Entities
{
    public class ResourceRequest : BaseEntity
    {
        public int RequestsId { get; set; }
        public int ResourceId { get; set; }
        public int Quantity { get; set; }
        public virtual Request Request { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
