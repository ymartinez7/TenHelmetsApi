namespace _10Helmets.API.Core.Entities
{
    using System;

    /// <summary>
    /// Base entity of all entities
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Automatic identficator
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// set is the item is active or inactive
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// creation date of the item 
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// modification date of the item
        /// </summary>
        public DateTime ModificatedDate { get; set; }
    }
}
