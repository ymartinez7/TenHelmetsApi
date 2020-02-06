using TenHelmets.API.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TenHelmets.API.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public void BeginTransaction()
        {
            //var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            //_context = contextManager.Context;
        }

        public int CommitTransaction()
        {
            //return _context.SaveChanges();
            return 1;
        }

        //public async Task<int> CommitTransactionAsync()
        //{
        //    return await _context.SaveChangesAsync();
        //}
    }
}
