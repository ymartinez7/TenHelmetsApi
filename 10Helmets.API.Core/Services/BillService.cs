namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class BillService : BaseService<Bill>, IBillService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="billRepository"></param>
        public BillService(IBillRepository billRepository)
            : base(billRepository)
        {

        }
    }
}
