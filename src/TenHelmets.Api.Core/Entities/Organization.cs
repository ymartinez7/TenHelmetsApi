using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<Unit> Units { get; private set; }

        public Organization()
        {
            Units = new HashSet<Unit>();
        }
    }
}
