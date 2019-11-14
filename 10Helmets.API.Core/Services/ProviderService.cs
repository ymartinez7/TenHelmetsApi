namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class ProviderService : BaseService<Provider>, IProviderService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="providerRepository"></param>
        public ProviderService(IProviderRepository providerRepository)
            : base(providerRepository)
        {

        }
    }
}
