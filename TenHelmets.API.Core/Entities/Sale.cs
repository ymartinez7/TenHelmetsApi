using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Sale : BaseEntity
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalAmount { get; set; }
        public int PaymentTypeId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual IEnumerable<SaleDetail> SaleDetails { get; private set; }

        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }
    }
}
