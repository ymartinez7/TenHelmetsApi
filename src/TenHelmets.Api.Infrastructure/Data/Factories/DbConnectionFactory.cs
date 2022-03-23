using TenHelmets.API.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.API.Infrastructure.Data.Factories
{
    public static class DbConnectionFactory
    {
        public static IDbConnection GetConnection(DbContext dbContext)
        {
            return null;
        }
    }
}
