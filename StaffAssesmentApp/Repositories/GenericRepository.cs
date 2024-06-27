using Microsoft.EntityFrameworkCore;
using StaffAssesmentApp.Data.Context;
using StaffAssessmentApp.Helpers;
using StaffAssessmentApp.Interfaces;
using StaffAssessmentApp.Interfaces.Models;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Result<T>> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            var changes = await _context.SaveChangesAsync();

            return (changes > 0) ? Result<T>.SuccessResult(entity) : Result<T>.NotFound($"Something happend while saving data");
        }

        public async Task DeleteAsync(int id)
        {
            var result = await GetByIdAsync(id);
            if (result.Data is IRecoverable recoverable)
            {
                recoverable.DeletedDate = DateTime.Now;
                recoverable.IsDeleted = true;
            }
            else
            {
                _context.Set<T>().Remove(result.Data);
            }
            await _context.SaveChangesAsync();

        }

        public async Task<Result<T>> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return Result<T>.NotFound($"Entity with id {id} not found.");
            }
            return Result<T>.SuccessResult(entity);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
