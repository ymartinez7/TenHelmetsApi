namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class InpectionService : BaseService<Inspection>, IInspectionService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inspectionRepository"></param>
        public InpectionService(IInspectionRepository inspectionRepository)
            : base(inspectionRepository)
        {

        }
    }
}
