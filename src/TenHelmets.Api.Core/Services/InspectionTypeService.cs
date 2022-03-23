using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class InspectionTypeService : BaseService<InspectionType>, IInspectionTypeService
    {
        public InspectionTypeService(IInspectionTypeRepository inspectionTypeRepository)
            : base(inspectionTypeRepository)
        {

        }
    }
}
