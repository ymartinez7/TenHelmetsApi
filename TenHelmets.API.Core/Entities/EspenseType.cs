using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class EspenseType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Espense> Espenses { get; private set; }

        public EspenseType()
        {
            this.Espenses = new HashSet<Espense>();
        }
    }
}
