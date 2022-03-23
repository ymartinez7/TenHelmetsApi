using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TenHelmets.API.Core.Interfaces.Repositories;
using TenHelmets.API.Core.Interfaces.Services;

namespace TenHelmets.API.Core.Services
{
    public class BaseService<T> : IDisposable, IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _baseRepository;


        public BaseService(IBaseRepository<T> repository)
        {
            _baseRepository = repository;
        }


        public T Add(T model)
        {
            return _baseRepository.Add(model);
        }

        public IEnumerable<T> Add(IEnumerable<T> model)
        {
            return _baseRepository.Add(model);
        }

        public async Task<T> AddAsync(T model)
        {
            return await _baseRepository.AddAsync(model);
        }

        public async Task<IEnumerable<T>> AddAsync(IEnumerable<T> model)
        {
            return await _baseRepository.AddAsync(model);
        }

        public void AddUoW(IEnumerable<T> model)
        {
            _baseRepository.AddUoW(model);
        }

        public void Delete(int id)
        {
            _baseRepository.Delete(id);
        }

        public void Delete(T model)
        {
            _baseRepository.Delete(model);
        }

        public void Delete(IEnumerable<T> model)
        {
            _baseRepository.Delete(model);
        }

        public async Task DeleteAsync(int id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task DeleteAsync(T model)
        {
            await _baseRepository.DeleteAsync(model);
        }

        public async Task DeleteAsync(IEnumerable<T> model)
        {
            await _baseRepository.DeleteAsync(model);
        }

        public void DeleteUoW(IEnumerable<T> model)
        {
            _baseRepository.DeleteUoW(model);
        }

        public int Count()
        {
            return _baseRepository.Count();
        }

        public T Find(int id)
        {
            return _baseRepository.Find(id);
        }

        public T Find(T model)
        {
            return _baseRepository.Find(model);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _baseRepository.Find(expression);
        }

        public async Task<T> FindAsync(int id)
        {
            return await _baseRepository.FindAsync(id);
        }

        public async Task<T> FindAsync(T model)
        {
            return await _baseRepository.FindAsync(model);
        }

        public async Task<IEnumerable<T>> FindAsync()
        {
            return await _baseRepository.FindAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await _baseRepository.FindAsync(expression);
        }

        public void Update(T model)
        {
            _baseRepository.Update(model);
        }

        public void Update(IEnumerable<T> model)
        {
            _baseRepository.Update(model);
        }

        public async Task UpdateAsync(T model)
        {
            await _baseRepository.UpdateAsync(model);
        }

        public async Task UpdateAsync(IEnumerable<T> model)
        {
            await _baseRepository.UpdateAsync(model);
        }

        public void UpdateUoW(IEnumerable<T> model)
        {
            _baseRepository.UpdateUoW(model);
        }

        public void Dispose()
        {
            _baseRepository.Dispose();
        }
    }
}
