namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Customer : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
            this.Surveys = new HashSet<Survey>();
            this.Sectors = new HashSet<Sector>();
            this.ServiceOrders = new HashSet<ServiceOrder>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Rif { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TaxAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int SectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ContactEmployeeFirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ContactEmployeeLastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Sector Sector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Sale> Sales { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Survey> Surveys { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Sector> Sectors { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ServiceOrder> ServiceOrders { get; private set; }
    }
}
