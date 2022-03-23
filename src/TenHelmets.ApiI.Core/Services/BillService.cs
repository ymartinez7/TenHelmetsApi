using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class BillService : BaseService<Bill>, IBillService
    {
        public BillService(IBillRepository billRepository)
            : base(billRepository)
        {

        }
    }
}
