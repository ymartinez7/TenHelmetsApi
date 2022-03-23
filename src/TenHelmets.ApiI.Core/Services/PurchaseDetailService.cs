using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class PurchaseDetailService : BaseService<PurchaseDetail>, IPurchaseDetailService
    {
        public PurchaseDetailService(IPurchaseDetailRepository purchaseDetailRepository)
            : base(purchaseDetailRepository)
        {

        }
    }
}
