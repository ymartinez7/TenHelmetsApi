namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProjectBudgetService : BaseService<ProjectBudget>, IProjectBudgetService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectBudgetRepository"></param>
        public ProjectBudgetService(IProjectBudgetRepository projectBudgetRepository)
            : base(projectBudgetRepository)
        {

        }
    }
}
