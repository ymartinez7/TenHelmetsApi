using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class AlertService : BaseService<Alert>, IAlertService
    {
        public AlertService(IAlertRepository alertRepository)
            : base(alertRepository)
        {

        }
    }
}
