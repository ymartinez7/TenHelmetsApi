namespace TenHelmets.API.Core.Entities
{
    public class Alert : BaseEntity
    {
        public int AlertTypeId { get; set; }
        public int ActivityId { get; set; }
        public int RequestId { get; set; }
        public int ProjectBudgetId { get; set; }
        public string Warning { get; set; }
        public string Critical { get; set; }
        public virtual AlertType AlertType { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual Request Request { get; set; }
        public virtual ProjectBudget ProjectBudget { get; set; }
    }
}
