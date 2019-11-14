namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class PaymentType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public PaymentType()
        {
            this.Bills = new HashSet<Bill>();
            this.Purchases = new HashSet<Purchase>();
            this.Sales = new HashSet<Sale>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Bill> Bills { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Purchase> Purchases { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Sale> Sales { get; private set; }
    }
}
