namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class CalService : BaseService<Cal>, ICalService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="calRepository"></param>
        public CalService(ICalRepository calRepository)
            : base(calRepository)
        {

        }
    }
}
