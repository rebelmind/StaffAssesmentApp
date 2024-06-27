

using StaffAssessmentApp.Helpers;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<Result<T>> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<Result<T>> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
