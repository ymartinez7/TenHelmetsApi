namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Priority : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Priority()
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
        public int MinTM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MaxTM { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AlertTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual AlertType AlertType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Request> Requests { get; private set; }
    }
}
