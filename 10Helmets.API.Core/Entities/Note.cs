namespace _10Helmets.API.Core.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Note : Base
    {
        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Activity Activity { get; set; }
    }
}
