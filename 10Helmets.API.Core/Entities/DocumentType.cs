namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class DocumentType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public DocumentType()
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
        public virtual IEnumerable<Employee> Employees { get; private set; }
    }
}
