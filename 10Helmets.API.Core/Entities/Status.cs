namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Status : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Status()
        {
            this.Bills = new HashSet<Bill>();
            this.Espenses = new HashSet<Espense>();
            this.Cals = new HashSet<Cal>();
            this.Requests = new HashSet<Request>();
            this.Activities = new HashSet<Activity>();
            this.Projects = new HashSet<Project>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

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
        public virtual IEnumerable<Cal> Cals { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Request> Requests { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Activity> Activities { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Project> Projects { get; private set; }
    }
}
