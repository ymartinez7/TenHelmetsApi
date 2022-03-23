namespace TenHelmets.API.Core.Entities
{
    public class Survey : BaseEntity
    {
        public int CustomerId { get; set; }
        //public int ProjectId { get; set; }
        public float Score { get; set; }
        public string Qualification { get; set; }
        public virtual Customer Customer { get; set; }
        //public virtual Project Project { get; set; }
    }
}
