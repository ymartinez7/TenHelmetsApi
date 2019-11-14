namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProjectService : BaseService<Project>, IProjectService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectRepository"></param>
        public ProjectService(IProjectRepository projectRepository)
            : base(projectRepository)
        {

        }
    }
}
