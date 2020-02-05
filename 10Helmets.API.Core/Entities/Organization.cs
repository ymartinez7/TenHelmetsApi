using System.Collections.Generic;

namespace _10Helmets.API.Core.Entities
{
    public class Organization : BaseEntity
    {
        public Organization()
        {
            this.Units = new HashSet<Unit>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Email { get; set; }

        public virtual IEnumerable<Unit> Units { get; private set; }
    }
}
