using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class RequestService : BaseService<Request>, IRequestService
    {
        public RequestService(IRequestRepository requestRepository)
            : base(requestRepository)
        {

        }
    }
}
