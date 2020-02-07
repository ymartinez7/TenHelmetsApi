using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class SaleService : BaseService<Sale>, ISaleService
    {
        public SaleService(ISaleRepository saleRepository)
            : base(saleRepository)
        {

        }
    }
}
