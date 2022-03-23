using TenHelmets.API.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.API.Infrastructure.Data.Interfaces
{
    public interface IConnectionManager
    {
        IDbConnection GetDbConnection(DbContext dbContext);
        IDocumentConnection GetDocumentConnection(DocumentTypeConnection documentTypeConnection);
        IServiceConnection GetServiceConnection(ServiceTypeConnection serviceTypeConnection);
    }
}
