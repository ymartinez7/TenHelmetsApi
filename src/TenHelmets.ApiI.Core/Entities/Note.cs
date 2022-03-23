namespace TenHelmets.API.Core.Entities
{
    public class Note : BaseEntity
    {
        public string Content { get; set; }
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
