namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class SaleService : BaseService<Sale>, ISaleService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleRepository"></param>
        public SaleService(ISaleRepository saleRepository)
            : base(saleRepository)
        {

        }
    }
}
