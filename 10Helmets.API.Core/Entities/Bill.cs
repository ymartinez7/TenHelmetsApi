namespace _10Helmets.API.Core.Entities
{
    using System;

    /// <summary>
    /// Register the bill of each project
    /// </summary>
    public sealed class Bill : Base
    {
        /// <summary>
        /// Associeted porject to the bill
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// bill date of the item
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Amount of the item
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// <see cref="PaymentType"/> associeted to the bill
        /// </summary>
        public int PaymentTypeId { get; set; }

        /// <summary>
        /// <see cref="Status"/> of the bill
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual PaymentType PaymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Status Status { get; set; }
    }
}
