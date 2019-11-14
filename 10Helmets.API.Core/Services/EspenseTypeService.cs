namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class EspenseTypeService : BaseService<EspenseType>, IEspenseTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="espenseTypeRepository"></param>
        public EspenseTypeService(IEspenseTypeRepository espenseTypeRepository)
            : base(espenseTypeRepository)
        {

        }
    }
}
