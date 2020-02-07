using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FirstSureName { get; set; }
        public string SecondSureName { get; set; }
        public int DocumentTypeId { get; set; }
        public string Document { get; set; }
        public int RolId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual IEnumerable<Espense> Espenses { get; private set; }
        public virtual IEnumerable<Purchase> Purchases { get; private set; }
        public virtual IEnumerable<Sale> Sales { get; private set; }
        public virtual IEnumerable<Cal> Cals { get; private set; }
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }
        public virtual IEnumerable<Request> Requests { get; private set; }
        public virtual IEnumerable<Activity> Activities { get; private set; }

        public Employee()
        {
            Espenses = new HashSet<Espense>();
            Purchases = new HashSet<Purchase>();
            Sales = new HashSet<Sale>();
            Cals = new HashSet<Cal>();
            ProjectBudgets = new HashSet<ProjectBudget>();
            Requests = new HashSet<Request>();
            Activities = new HashSet<Activity>();
        }
    }
}
