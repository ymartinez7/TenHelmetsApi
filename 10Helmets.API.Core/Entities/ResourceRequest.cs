namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourceRequest : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int RequestsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Request Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Resource Resource { get; set; }
    }
}
