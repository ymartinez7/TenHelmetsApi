using System;

namespace TenHelmets.API.Core.Entities
{
    public class Espense : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int EspenseTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        //public int ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Reimbursement { get; set; }
        public decimal ReimbursementAmount { get; set; }
        public DateTime ReimbursementDate { get; set; }
        public int StatusId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual EspenseType EspenseType { get; set; }
        //public virtual Project Project { get; set; }
        public virtual Status Status { get; set; }
    }
}
