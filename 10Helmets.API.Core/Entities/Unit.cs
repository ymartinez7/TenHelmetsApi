namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Unit : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Unit()
        {
            this.ProjectBudgets = new HashSet<ProjectBudget>();
            this.RequestTypes = new HashSet<RequestType>();
            this.Roles = new HashSet<Rol>();
            this.ServiceOrders = new HashSet<ServiceOrder>();
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
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Organization Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ProjectBudget> ProjectBudgets { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<RequestType> RequestTypes { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Rol> Roles { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ServiceOrder> ServiceOrders { get; private set; }
    }
}
