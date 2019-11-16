namespace _10Helmets.API.Core.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class Request : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public Request()
        {
            this.ResourceRequests = new HashSet<ResourceRequest>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int RequestTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RequiredDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PriorityId { get; set; }

        /// <summary>
        /// /
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Accomplish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual RequestType RequestType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Project Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Priority Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Status Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ResourceRequest> ResourceRequests { get; private set; }
    }
}
