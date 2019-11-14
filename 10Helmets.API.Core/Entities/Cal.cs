namespace _10Helmets.API.Core.Entities
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public sealed class Cal : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime DetectionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// /
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Analysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ActionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CorrectionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorrectionResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Activity Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ActionType ActionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Status Status { get; set; }
    }
}
