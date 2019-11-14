namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Sale : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public Sale()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PaymentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual PaymentType PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }
    }
}
