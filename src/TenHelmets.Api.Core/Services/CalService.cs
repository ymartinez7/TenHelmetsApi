using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class CalService : BaseService<Cal>, ICalService
    {
        public CalService(ICalRepository calRepository)
            : base(calRepository)
        {

        }
    }
}
