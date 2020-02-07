using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Rif { get; set; }
        public string TaxAddress { get; set; }
        public int SectorId { get; set; }
        public string ContactEmployeeFirstName { get; set; }
        public string ContactEmployeeLastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual Sector Sector { get; set; }
        public virtual IEnumerable<Sale> Sales { get; private set; }
        public virtual IEnumerable<Survey> Surveys { get; private set; }
        public virtual IEnumerable<ServiceOrder> ServiceOrders { get; private set; }

        public Customer()
        {
            this.Sales = new HashSet<Sale>();
            this.Surveys = new HashSet<Survey>();
            this.ServiceOrders = new HashSet<ServiceOrder>();
        }
    }
}
