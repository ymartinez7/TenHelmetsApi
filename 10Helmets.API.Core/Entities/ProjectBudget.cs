namespace _10Helmets.API.Core.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class ProjectBudget : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public ProjectBudget()
        {
            this.Alerts = new HashSet<Alert>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// /
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Alert> Alerts { get; private set; }
    }
}
