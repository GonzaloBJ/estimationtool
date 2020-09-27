using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly EstimationToolContext _context;

        public GenericRepository(EstimationToolContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T t)
        {
            var result = _context.Set<T>().Add(t);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> UpdateAsync(T t)
        {
            var result = _context.Set<T>().Update(t);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> RemoveAsync(T t)
        {
            var result = _context.Set<T>().Remove(t);
            await _context.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }
    }
}