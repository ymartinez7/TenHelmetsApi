using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TenHelmets.API.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : class
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
        T Find(int id);
        T Find(T model);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<T> FindAsync(int id);
        Task<T> FindAsync(T model);
        Task<IEnumerable<T>> FindAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        void Update(T model);
        void Update(IEnumerable<T> model);
        Task UpdateAsync(T model);
        Task UpdateAsync(IEnumerable<T> model);
        void UpdateUoW(IEnumerable<T> model);
        void Dispose();
    }
}
