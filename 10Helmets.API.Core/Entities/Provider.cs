namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Provider : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public Provider()
        {
            this.Actiities = new HashSet<Activity>();
            this.Purchases = new HashSet<Purchase>();
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
        public string LocalNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Email Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Sector Sector { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Activity> Actiities { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Purchase> Purchases { get; private set; }
    }
}
