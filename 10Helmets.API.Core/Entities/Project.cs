namespace _10Helmets.API.Core.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Project : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public Project()
        {
            this.Bills = new HashSet<Bill>();
            this.Espenses = new HashSet<Espense>();
            this.ProjectBudgets = new HashSet<ProjectBudget>();
            this.Surveys = new HashSet<Survey>();
            this.Requests = new HashSet<Request>();
            this.Activities = new HashSet<Activity>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ServiceOrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ServiceOrder ServiceOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Bill> Bills { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Espense> Espenses { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Survey> Surveys { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Request> Requests { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Activity> Activities { get; private set; }
    }
}
