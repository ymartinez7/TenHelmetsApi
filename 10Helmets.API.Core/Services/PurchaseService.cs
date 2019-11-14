namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class PurchaseService : BaseService<Purchase>, IPurchaseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="purchaseRepository"></param>
        public PurchaseService(IPurchaseRepository purchaseRepository)
            : base(purchaseRepository)
        {

        }
    }
}
