using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Entities;

namespace Api.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         Task<T> AddAsync(T t);
         Task<T> GetByIdAsync(int id);
         Task<IReadOnlyList<T>> ListAllAsync();
         Task<T> UpdateAsync(T t);
         Task<T> RemoveAsync(T t);
         Task<T> GetEntityWithSpec(ISpecification<T> spec);
         Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
         Task<int> CountAsync(ISpecification<T> spec);
    }
}