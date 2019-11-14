namespace _10Helmets.API.Core.Interfaces.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseService<T> where T : class
    {
        /// <summary>
        /// 
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
        /// <returns></returns>
        T Find(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        T Find(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> FindAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<T> FindAsync(T model);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> FindAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);

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
