using System.Collections.Generic;

namespace TenHelmets.API.Core.Entities
{
    public class RequestType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual IEnumerable<Request> Requests { get; private set; }
    }
}
