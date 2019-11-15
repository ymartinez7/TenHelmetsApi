namespace _10Helmets.API.Infrastructure.Data.Repositories
{
    using _10Helmets.API.Core.Entities;
    using _10Helmets.API.Core.Interfaces.Repositories;
    using _10Helmets.API.Infrastructure.Data.Context;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : BaseEntity
    {
        #region properties
        /// <summary>
        /// 
        /// </summary>
        protected DbContext DbContext { get; private set; }
        #endregion

        #region constructor
        /// <summary>
        /// 
        /// </summary>
        public BaseRepository()
        {
            //DbContext = ServiceLocator.Current.GetInstance<ContextManager>().Context;
            DbContext = new ApplicationDbContext();
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
            try
            {
                //model = DbContext.Set<T>().Add(model);
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IEnumerable<T> Add(IEnumerable<T> model)
        {
            try
            {
                //model = DbContext.Set<T>().AddRange(model);
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<T> AddAsync(T model)
        {
            try
            {
                //model = DbContext.Set<T>().Add(model);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> AddAsync(IEnumerable<T> model)
        {
            try
            {
                //model = DbContext.Set<T>().AddRange(model);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void AddUoW(IEnumerable<T> model)
        {
            DbContext.Set<T>().AddRange(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            var model = Find(id);

            if (model == null)
                throw new ArgumentNullException();

            Delete(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(T model)
        {
            try
            {
                DbContext.Set<T>().Remove(model);
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(IEnumerable<T> model)
        {
            try
            {
                DbContext.Set<T>().RemoveRange(model);
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            var model = Find(id);

            if (model == null)
                throw new ArgumentNullException();

            await DeleteAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task DeleteAsync(T model)
        {
            try
            {
                DbContext.Set<T>().Remove(model);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task DeleteAsync(IEnumerable<T> model)
        {
            try
            {
                DbContext.Set<T>().RemoveRange(model);
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void DeleteUoW(IEnumerable<T> model)
        {
            DbContext.Set<T>().RemoveRange(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public int Count()
        {
            return DbContext.Set<T>().Count();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public T Find(int id, [Optional] bool active)
        {
            return DbContext.Set<T>().Find(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public T Find(T model, [Optional] bool active)
        {
            return DbContext.Set<T>().Find(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression, [Optional] bool active)
        {
            return DbContext.Set<T>().Where(expression).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(int id, [Optional] bool active)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public async Task<T> FindAsync(T model, [Optional] bool active)
        {
            return await DbContext.Set<T>().FindAsync(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="active"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> FindAsync([Optional] bool active)
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="active"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression, [Optional] bool active)
        {
            return await DbContext.Set<T>().Where(expression).ToListAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Update(T model)
        {
            try
            {
                //DbContext.Set<T>().Attach(model);
                DbContext.Entry(model).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Update(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                    //DbContext.Set<T>().Attach(item);
                    DbContext.Entry(item).State = EntityState.Modified;
                }
                SaveChanges();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateAsync(T model)
        {
            try
            {
                DbContext.Entry(model).State = EntityState.Modified;
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateAsync(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                    DbContext.Entry(item).State = EntityState.Modified;
                }
                await SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void UpdateUoW(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                    DbContext.Entry(item).State = EntityState.Modified;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if (DbContext != null)
            {
                DbContext.Dispose();
            }
        }
        #endregion
    }
}
