using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class BrandService : BaseService<Brand>, IBrandService
    {
        public BrandService(IBrandRepository brandRepository)
            : base(brandRepository)
        {

        }
    }
}
