namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RequestTypeService : BaseService<RequestType>, IRequestTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="requestTypeRepository"></param>
        public RequestTypeService(IRequestTypeRepository requestTypeRepository)
            : base(requestTypeRepository)
        {

        }
    }
}
