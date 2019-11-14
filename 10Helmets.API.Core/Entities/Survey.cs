namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Survey : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Qualification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Project Project { get; set; }
    }
}
