using TenHelmets.API.Core.Entities;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Infrastructure.Data.Context;
using TenHelmets.API.Infrastructure.Data.Factories;
using TenHelmets.API.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace TenHelmets.API.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly IConnectionManager _connectionMaanager;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._connectionMaanager = ConnectionManagerFactory.ObtenerInstancia;
        }

        public T Add(T model)
        {
            try
            {
                this._dbContext.Set<T>().Add(model);
                SaveChanges();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<T> Add(IEnumerable<T> model)
        {
            try
            {
                this._dbContext.Set<T>().AddRange(model);
                SaveChanges();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> AddAsync(T model)
        {
            try
            {
                this._dbContext.Set<T>().Add(model);
                await SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> AddAsync(IEnumerable<T> model)
        {
            try
            {
                this._dbContext.Set<T>().AddRange(model);
                await SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AddUoW(IEnumerable<T> model)
        {
            this._dbContext.Set<T>().AddRange(model);
        }

        public void Delete(int id)
        {
            var model = this.Find(id);

            if (model == null)
                throw new ArgumentNullException();

            this.Delete(model);
        }

        public void Delete(T model)
        {
            try
            {
                this._dbContext.Set<T>().Remove(model);
                SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(IEnumerable<T> model)
        {
            try
            {
                this._dbContext.Set<T>().RemoveRange(model);
                SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var model = this.Find(id);

            if (model == null)
                throw new ArgumentNullException();

            await this.DeleteAsync(model);
        }

        public async Task DeleteAsync(T model)
        {
            try
            {
                this._dbContext.Set<T>().Remove(model);
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteAsync(IEnumerable<T> model)
        {
            try
            {
                this._dbContext.Set<T>().RemoveRange(model);
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteUoW(IEnumerable<T> model)
        {
            this._dbContext.Set<T>().RemoveRange(model);
        }

        public int Count()
        {
            return this._dbContext.Set<T>().Count();
        }

        public T Find(int id, 
            [Optional]bool active)
        {
            return this._dbContext.Set<T>().Find(id);
        }

        public T Find(T model, 
            [Optional] bool active)
        {
            return this._dbContext.Set<T>().Find(model);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression, 
            [Optional] bool active)
        {
            return this._dbContext.Set<T>().Where(expression).ToList();
        }

        public async Task<T> FindAsync(int id, 
            [Optional] bool active)
        {
            return await this._dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> FindAsync(T model, 
            [Optional] bool active)
        {
            return await this._dbContext.Set<T>().FindAsync(model);
        }

        public async Task<IEnumerable<T>> FindAsync([Optional] bool active)
        {
            return await this._dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression, 
            [Optional] bool active)
        {
            return await this._dbContext.Set<T>().Where(expression).ToListAsync();
        }

        public void Update(T model)
        {
            try
            {
                //DbContext.Set<T>().Attach(model);
                this._dbContext.Entry(model).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                    //DbContext.Set<T>().Attach(item);
                    this._dbContext.Entry(item).State = EntityState.Modified;
                }
                SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(T model)
        {
            try
            {
                this._dbContext.Entry(model).State = EntityState.Modified;
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateAsync(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                    this._dbContext.Entry(item).State = EntityState.Modified;
                }
                await SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateUoW(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                   this._dbContext.Entry(item).State = EntityState.Modified;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int SaveChanges()
        {
            return this._dbContext.SaveChanges();
        }

        private async Task<int> SaveChangesAsync()
        {
            return await this._dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (this._dbContext != null)
            {
                this._dbContext.Dispose();
            }
        }
    }
}
