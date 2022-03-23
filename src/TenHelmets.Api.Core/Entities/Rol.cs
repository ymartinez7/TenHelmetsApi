using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Rol : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual IEnumerable<Employee> Employees { get; private set; }

        public Rol()
        {
            Employees = new HashSet<Employee>();
        }

    }
}
