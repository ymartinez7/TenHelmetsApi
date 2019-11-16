namespace _10Helmets.API.Infrastructure.Data.Factories
{
    using _10Helmets.API.Infrastructure.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 
    /// </summary>
    public static class DbConnectionFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        /// <returns></returns>
        public static IDbConnection GetConnection(DbContext dbContext)
        {
            return null;
        }
    }
}
