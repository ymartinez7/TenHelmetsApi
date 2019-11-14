namespace _10Helmets.API.Core.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class ActionType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public ActionType()
        {
            this.Cals = new HashSet<Cal>();
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Cal> Cals { get; private set; }
    }
}
