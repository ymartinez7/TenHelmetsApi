namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AlertService : BaseService<Alert>, IAlertService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alertRepository"></param>
        public AlertService(IAlertRepository alertRepository)
            : base(alertRepository)
        {

        }
    }
}
