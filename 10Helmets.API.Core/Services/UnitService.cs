namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class UnitService : BaseService<Unit>, IUnitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitRepository"></param>
        public UnitService(IUnitRepository unitRepository)
            : base(unitRepository)
        {

        }
    }
}
