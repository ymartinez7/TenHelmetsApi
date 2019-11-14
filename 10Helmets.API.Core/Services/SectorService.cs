namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SectorService : BaseService<Sector>, ISectorService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectorRepository"></param>
        public SectorService(ISectorRepository sectorRepository)
            : base(sectorRepository)
        {

        }
    }
}
