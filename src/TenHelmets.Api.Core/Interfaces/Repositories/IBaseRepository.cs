using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace TenHelmets.API.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T model);
        IEnumerable<T> Add(IEnumerable<T> model);
        Task<T> AddAsync(T model);
        Task<IEnumerable<T>> AddAsync(IEnumerable<T> model);
        void AddUoW(IEnumerable<T> model);
        void Delete(int id);
        void Delete(T model);
        void Delete(IEnumerable<T> model);
        Task DeleteAsync(int id);
        Task DeleteAsync(T model);
        Task DeleteAsync(IEnumerable<T> model);
        void DeleteUoW(IEnumerable<T> model);
        int Count();
        T Find(int id, [Optional] bool active);
        T Find(T model, [Optional] bool active);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression, [Optional] bool active);
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression, [Optional] bool active);
        Task<T> FindAsync(int id, [Optional] bool active);
        Task<T> FindAsync(T model, [Optional] bool active);
        Task<IEnumerable<T>> FindAsync([Optional] bool active);
        void Update(T model);
        void Update(IEnumerable<T> model);
        Task UpdateAsync(T model);
        Task UpdateAsync(IEnumerable<T> model);
        void UpdateUoW(IEnumerable<T> model);
        void Dispose();
    }
}
