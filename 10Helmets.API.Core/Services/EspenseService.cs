namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EspenseService : BaseService<Espense>, IEspenseService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="espenseRepository"></param>
        public EspenseService(IEspenseRepository espenseRepository)
            : base(espenseRepository)
        {

        }
    }
}
