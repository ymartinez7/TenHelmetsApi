using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public virtual IEnumerable<Resource> Resources { get; private set; }

        public Brand()
        {
            this.Resources = new HashSet<Resource>();
        }
    }
}
