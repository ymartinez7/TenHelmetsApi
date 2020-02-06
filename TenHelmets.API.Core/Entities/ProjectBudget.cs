using System;
using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class ProjectBudget : BaseEntity
    {
        public int UnitId { get; set; }
        public int ProjectId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ApprovalDate { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual IEnumerable<Alert> Alerts { get; private set; }

        public ProjectBudget()
        {
            Alerts = new HashSet<Alert>();
        }
    }
}
