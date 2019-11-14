namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public class ActionTypeService : BaseService<ActionType>, IActionTypeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="actionTypeRepository"></param>
        public ActionTypeService(IActionTypeRepository actionTypeRepository)
            : base(actionTypeRepository)
        {

        }
    }
}
