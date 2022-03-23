using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Sector : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Provider> Providers { get; private set; }
        public virtual IEnumerable<Customer> Customers { get; private set; }

        public Sector()
        {
            Providers = new HashSet<Provider>();
            Customers = new HashSet<Customer>();
        }
    }
}
