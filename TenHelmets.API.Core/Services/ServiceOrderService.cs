using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ServiceOrderService : BaseService<ServiceOrder>, IServiceOrderService
    {
        public ServiceOrderService(IServiceOrderRepository serviceOrderRepository)
            : base(serviceOrderRepository)
        {

        }
    }
}
