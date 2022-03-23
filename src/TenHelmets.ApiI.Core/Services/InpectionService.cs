using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class InpectionService : BaseService<Inspection>, IInspectionService
    {
        public InpectionService(IInspectionRepository inspectionRepository)
            : base(inspectionRepository)
        {

        }
    }
}
