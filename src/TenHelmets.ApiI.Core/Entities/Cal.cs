using System;

namespace TenHelmets.API.Core.Entities
{
    public class Cal : BaseEntity
    {
        public DateTime DetectionDate { get; set; }
        public int ActivityId { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public string Analysis { get; set; }
        public int ActionTypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime CorrectionDate { get; set; }
        public string CorrectionResult { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ActionType ActionType { get; set; }
        public virtual Status Status { get; set; }
    }
}
