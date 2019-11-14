namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class RequestType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public RequestType()
        {
            this.Requests = new HashSet<Request>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Unit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Request> Requests { get; private set; }
    }
}
