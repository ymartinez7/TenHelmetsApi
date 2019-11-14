namespace _10Helmets.API.Core.Entities
{
    using System;
    using System.Collections.Generic;

    public class Purchase : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Purchase()
        {
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProviderId { get; set; }

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
        public virtual Request Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Provider Provider { get; set; }

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
        public virtual IEnumerable<PurchaseDetail> PurchaseDetails { get; private set; }
    }
}
