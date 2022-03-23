namespace TenHelmets.API.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        int CommitTransaction();
        //Task<int> CommitTransactionAsync();
    }
}
