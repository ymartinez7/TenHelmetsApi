using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class SaleDetailService : BaseService<SaleDetail>, ISaleDetailService
    {
        public SaleDetailService(ISaleDetailRepository saleDetailRepository)
            : base(saleDetailRepository)
        {

        }
    }
}
