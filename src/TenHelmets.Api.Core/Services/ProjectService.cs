using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public sealed class ProjectService : BaseService<Project>, IProjectService
    {
        public ProjectService(IProjectRepository projectRepository)
            : base(projectRepository)
        {

        }
    }
}
