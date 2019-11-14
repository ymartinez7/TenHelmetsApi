namespace _10Helmets.API.Core.Entities
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Espense : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EspenseTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Reimbursement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal ReimbursementAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ReimbursementDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual EspenseType EspenseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Status Status { get; set; }
    }
}
