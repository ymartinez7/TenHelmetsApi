namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;

    /// <summary>
    /// 
    /// </summary>
    public sealed class ProjectBudgetRepository : BaseRepository<ProjectBudget>, IProjectBudgetRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public ProjectBudgetRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
