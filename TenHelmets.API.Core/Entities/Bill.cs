using System;

namespace TenHelmets.API.Core.Entities
{
    public class Bill : BaseEntity
    {
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public int PaymentTypeId { get; set; }
        //public int StatusId { get; set; }
        public virtual Project Project { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        //public virtual Status Status { get; set; }
    }
}
