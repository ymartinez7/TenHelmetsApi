namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class AlertTypeService : BaseService<AlertType>, IAlertTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alertTypeRepository"></param>
        public AlertTypeService(IAlertTypeRepository alertTypeRepository)
            : base(alertTypeRepository)
        {

        }
    }
}
