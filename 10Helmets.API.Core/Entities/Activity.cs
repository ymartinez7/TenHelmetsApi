namespace _10Helmets.API.Core.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Activity : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public Activity()
        {
            this.Inspections = new HashSet<Inspection>();
            this.Cals = new HashSet<Cal>();
            this.Alerts = new HashSet<Alert>();
            this.Notes = new HashSet<Note>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ActivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

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
        public int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Accomplish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AlertTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ActivityType ActivityType { get; set; }

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
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual AlertType AlertType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Inspection> Inspections { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Cal> Cals { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Alert> Alerts { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Note> Notes { get; private set; }
    }
}
