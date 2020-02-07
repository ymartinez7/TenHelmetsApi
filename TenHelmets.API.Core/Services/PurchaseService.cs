using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class PurchaseService : BaseService<Purchase>, IPurchaseService
    {
        public PurchaseService(IPurchaseRepository purchaseRepository)
            : base(purchaseRepository)
        {

        }
    }
}
