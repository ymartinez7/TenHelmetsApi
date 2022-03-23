using System;
using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Purchase : BaseEntity
    {
        public int RequestId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ProviderId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalAmount { get; set; }
        public int PaymentTypeId { get; set; }
        public virtual Request Request { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual IEnumerable<PurchaseDetail> PurchaseDetails { get; private set; }

        public Purchase()
        {
            PurchaseDetails = new HashSet<PurchaseDetail>();
        }
    }
}
