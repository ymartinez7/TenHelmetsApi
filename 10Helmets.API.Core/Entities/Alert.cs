namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Alert : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int AlertTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProjectBudgetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Warning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Critical { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual AlertType AlertType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Activity Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Request Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ProjectBudget ProjectBudget { get; set; }
    }
}
