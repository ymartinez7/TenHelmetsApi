namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Interfaces.Repositories;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// 
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// 
        /// </summary>
        private DbContext _context;

        /// <summary>
        /// 
        /// </summary>
        public void BeginTransaction()
        {
            //var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();
            //_context = contextManager.Context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int CommitTransaction()
        {
            //return _context.SaveChanges();
            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //public async Task<int> CommitTransactionAsync()
        //{
        //    return await _context.SaveChangesAsync();
        //}
    }
}
