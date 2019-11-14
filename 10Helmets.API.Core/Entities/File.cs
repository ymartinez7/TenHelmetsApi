namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class File : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ServiceOrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ServiceOrder ServiceOrder { get; set; }
    }
}
