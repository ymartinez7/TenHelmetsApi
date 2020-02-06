using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class RequestTypeService : BaseService<RequestType>, IRequestTypeService
    {
        public RequestTypeService(IRequestTypeRepository requestTypeRepository)
            : base(requestTypeRepository)
        {

        }
    }
}
