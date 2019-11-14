namespace _10Helmets.API.Core.Interfaces.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// /
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        T Add(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        IEnumerable<T> Add(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<T> AddAsync(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> AddAsync(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void AddUoW(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Delete(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Delete(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task DeleteAsync(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task DeleteAsync(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void DeleteUoW(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        T Find(int id, [Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        T Find(T model, [Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> expression, [Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression, [Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        Task<T> FindAsync(int id, [Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        Task<T> FindAsync(T model, [Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="active"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> FindAsync([Optional] bool active);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Update(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Update(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateAsync(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task UpdateAsync(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void UpdateUoW(IEnumerable<T> model);

        /// <summary>
        /// 
        /// </summary>
        void Dispose();
    }
}
