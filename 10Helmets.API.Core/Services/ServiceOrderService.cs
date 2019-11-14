namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ServiceOrderService : BaseService<ServiceOrder>, IServiceOrderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceOrderRepository"></param>
        public ServiceOrderService(IServiceOrderRepository serviceOrderRepository)
            : base(serviceOrderRepository)
        {

        }
    }
}
