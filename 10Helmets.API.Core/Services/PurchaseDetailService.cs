namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class PurchaseDetailService : BaseService<PurchaseDetail>, IPurchaseDetailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="purchaseDetailRepository"></param>
        public PurchaseDetailService(IPurchaseDetailRepository purchaseDetailRepository)
            : base(purchaseDetailRepository)
        {

        }
    }
}
