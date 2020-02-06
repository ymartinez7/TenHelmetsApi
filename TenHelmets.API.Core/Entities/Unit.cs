using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }
        public virtual IEnumerable<RequestType> RequestTypes { get; private set; }
        public virtual IEnumerable<Rol> Roles { get; private set; }
        public virtual IEnumerable<ServiceOrder> ServiceOrders { get; private set; }

        public Unit()
        {
            ProjectBudgets = new HashSet<ProjectBudget>();
            RequestTypes = new HashSet<RequestType>();
            Roles = new HashSet<Rol>();
            ServiceOrders = new HashSet<ServiceOrder>();
        }
    }
}
