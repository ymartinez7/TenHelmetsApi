using System;
using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Activity : BaseEntity
    {
        public string Name { get; set; }
        public int ActivityTypeId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int ProviderId { get; set; }
        public bool Accomplish { get; set; }
        public int StatusId { get; set; }
        public int AlertTypeId { get; set; }
        public virtual ActivityType ActivityType { get; set; }
        //public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Status Status { get; set; }
        public virtual AlertType AlertType { get; set; }
        public virtual IEnumerable<Inspection> Inspections { get; private set; }
        public virtual IEnumerable<Cal> Cals { get; private set; }
        public virtual IEnumerable<Alert> Alerts { get; private set; }
        public virtual IEnumerable<Note> Notes { get; private set; }

        public Activity()
        {
            Inspections = new HashSet<Inspection>();
            Cals = new HashSet<Cal>();
            Alerts = new HashSet<Alert>();
            Notes = new HashSet<Note>();
        }
    }
}
