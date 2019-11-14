namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Rol : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public Rol()
        {
            this.Employees = new HashSet<Employee>();
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
        public int UnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Employee> Employees { get; private set; }
    }
}
