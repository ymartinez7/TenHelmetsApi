namespace TenHelmets.API.Core.Entities
{
    public class SaleDetail : BaseEntity
    {
        public int SaleId { get; set; }
        public int ResourceId { get; set; }
        public int ModelId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual Model Model { get; set; }
    }
}
