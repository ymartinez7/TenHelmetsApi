namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RequestService : BaseService<Request>, IRequestService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestRepository"></param>
        public RequestService(IRequestRepository requestRepository)
            : base(requestRepository)
        {

        }
    }
}
