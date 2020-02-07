using System;

namespace TenHelmets.API.Core.Entities
{
    public class Inspection : BaseEntity
    {
        public int ActivityId { get; set; }
        public int InspectionTypeId { get; set; }
        public DateTime Date { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual InspectionType InspectionType { get; set; }
    }
}
