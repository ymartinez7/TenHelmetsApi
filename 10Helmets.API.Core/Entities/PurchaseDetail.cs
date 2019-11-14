namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class PurchaseDetail : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public int PurchaseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Item { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Purchase Purchase { get; set; }
    }
}
