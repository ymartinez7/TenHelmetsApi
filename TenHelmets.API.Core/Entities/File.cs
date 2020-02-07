namespace TenHelmets.API.Core.Entities
{
    public class File : BaseEntity
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Extension { get; set; }
        public int ServiceOrderId { get; set; }
        public virtual ServiceOrder ServiceOrder { get; set; }
    }
}
