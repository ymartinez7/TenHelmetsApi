using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class AlertTypeService : BaseService<AlertType>, IAlertTypeService
    {
        public AlertTypeService(IAlertTypeRepository alertTypeRepository)
            : base(alertTypeRepository)
        {

        }
    }
}
