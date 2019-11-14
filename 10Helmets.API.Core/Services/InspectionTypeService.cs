namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class InspectionTypeService : BaseService<InspectionType>, IInspectionTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inspectionTypeRepository"></param>
        public InspectionTypeService(IInspectionTypeRepository inspectionTypeRepository)
            : base(inspectionTypeRepository)
        {

        }
    }
}
