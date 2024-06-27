using Microsoft.EntityFrameworkCore;
using StaffAssesmentApp.Data.Context;
using StaffAssessmentApp.Helpers;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Repositories
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        private readonly AppDbContext _context;
        public TestRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Result<Test>> GetByIdWithIncludes(int id)
        {
            var result = await _context.Tests.Include(z => z.Questions).ThenInclude(a=>a.Answers).ToListAsync();
            var test = result.Find(z => z.Id == id);
            if (test == null)
            {
                return Result<Test>.NotFound($"Entity with id {id} not found.");
            }
            return Result<Test>.SuccessResult(test);
        }
    }
}
