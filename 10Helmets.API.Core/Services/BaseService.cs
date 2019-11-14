namespace _10Helmets.API.Core.Services
{
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Core.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        protected readonly IBaseRepository<T> _baseRepository;
        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public BaseService(IBaseRepository<T> repository)
        {
            this._baseRepository = repository;
        }
        #endregion

        #region methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public T Add(T model)
        {
            return this._baseRepository.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IEnumerable<T> Add(IEnumerable<T> model)
        {
            return this._baseRepository.Add(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> AddAsync(T model)
        {
            return await this._baseRepository.AddAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> AddAsync(IEnumerable<T> model)
        {
            return await this._baseRepository.AddAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void AddUoW(IEnumerable<T> model)
        {
            this._baseRepository.AddUoW(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            this._baseRepository.Delete(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(T model)
        {
            this._baseRepository.Delete(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(IEnumerable<T> model)
        {
            this._baseRepository.Delete(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            await this._baseRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task DeleteAsync(T model)
        {
            await this._baseRepository.DeleteAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task DeleteAsync(IEnumerable<T> model)
        {
            await this._baseRepository.DeleteAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void DeleteUoW(IEnumerable<T> model)
        {
            this._baseRepository.DeleteUoW(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return this._baseRepository.Count();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Find(int id)
        {
            return this._baseRepository.Find(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public T Find(T model)
        {
            return this._baseRepository.Find(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return this._baseRepository.Find(expression);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(int id)
        {
            return await this._baseRepository.FindAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(T model)
        {
            return await this._baseRepository.FindAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<T>> FindAsync()
        {
            return await this._baseRepository.FindAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await this._baseRepository.FindAsync(expression);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Update(T model)
        {
            this._baseRepository.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Update(IEnumerable<T> model)
        {
            this._baseRepository.Update(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateAsync(T model)
        {
            await this._baseRepository.UpdateAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateAsync(IEnumerable<T> model)
        {
            await this._baseRepository.UpdateAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void UpdateUoW(IEnumerable<T> model)
        {
            this._baseRepository.UpdateUoW(model);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            this._baseRepository.Dispose();
        }
        #endregion
    }
}
