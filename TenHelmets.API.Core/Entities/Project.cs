using System;
using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Project : BaseEntity
    {
        public string Code { get; set; }
        public int ServiceOrderId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }
        public virtual ServiceOrder ServiceOrder { get; set; }
        public virtual Status Status { get; set; }
        public virtual IEnumerable<Bill> Bills { get; private set; }
        public virtual IEnumerable<Espense> Espenses { get; private set; }
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }
        public virtual IEnumerable<Survey> Surveys { get; private set; }
        public virtual IEnumerable<Request> Requests { get; private set; }
        public virtual IEnumerable<Activity> Activities { get; private set; }

        public Project()
        {
            Bills = new HashSet<Bill>();
            Espenses = new HashSet<Espense>();
            ProjectBudgets = new HashSet<ProjectBudget>();
            Surveys = new HashSet<Survey>();
            Requests = new HashSet<Request>();
            Activities = new HashSet<Activity>();
        }
    }
}
