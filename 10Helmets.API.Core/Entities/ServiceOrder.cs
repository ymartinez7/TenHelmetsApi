namespace _10Helmets.API.Core.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class ServiceOrder : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public ServiceOrder()
        {
            this.Projects = new HashSet<Project>();
            this.Files = new HashSet<File>();
        }

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
        public int CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ReceptionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Project> Projects { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<File> Files { get; private set; }
    }
}
