namespace TenHelmets.API.Core.Entities
{
    public class PurchaseDetail : BaseEntity
    {
        public int PurchaseId { get; set; }
        public string Item { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
