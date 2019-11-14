namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Employee : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Employee()
        {
            this.Espenses = new HashSet<Espense>();
            this.Purchases = new HashSet<Purchase>();
            this.Sales = new HashSet<Sale>();
            this.Cals = new HashSet<Cal>();
            this.ProjectBudgets = new HashSet<ProjectBudget>();
            this.Requests = new HashSet<Request>();
            this.Activities = new HashSet<Activity>();
            this.Roles = new HashSet<Rol>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstSureName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SecondSureName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Email Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DocumentType DocumentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Rol Rol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Espense> Espenses { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Purchase> Purchases { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Sale> Sales { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Cal> Cals { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }

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
        public virtual IEnumerable<Rol> Roles { get; private set; }
    }
}
