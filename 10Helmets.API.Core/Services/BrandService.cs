namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class BrandService : BaseService<Brand>, IBrandService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="brandRepository"></param>
        public BrandService(IBrandRepository brandRepository)
            : base(brandRepository)
        {

        }
    }
}
