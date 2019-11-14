namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class SaleDetail : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int SaleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ModelId { get; set; }

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
        public virtual Sale Sale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Model Model { get; set; }
    }
}
