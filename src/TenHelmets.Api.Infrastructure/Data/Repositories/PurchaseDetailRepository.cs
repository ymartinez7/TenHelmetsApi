using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Infrastructure.Data.Context;

namespace TenHelmets.API.Infrastructure.Data.Repositories
{
    public sealed class PurchaseDetailRepository : BaseRepository<PurchaseDetail>, IPurchaseDetailRepository
    {
        public PurchaseDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
