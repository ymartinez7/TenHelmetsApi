using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ProjectBudgetService : BaseService<ProjectBudget>, IProjectBudgetService
    {
        public ProjectBudgetService(IProjectBudgetRepository projectBudgetRepository)
            : base(projectBudgetRepository)
        {

        }
    }
}
