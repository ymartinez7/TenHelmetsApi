namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class SaleDetailService : BaseService<SaleDetail>, ISaleDetailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saleDetailRepository"></param>
        public SaleDetailService(ISaleDetailRepository saleDetailRepository)
            : base(saleDetailRepository)
        {

        }
    }
}
