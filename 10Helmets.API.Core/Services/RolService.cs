namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class RolService : BaseService<Rol>, IRolService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rolRepository"></param>
        public RolService(IRolRepository rolRepository)
            : base(rolRepository)
        {

        }
    }
}
