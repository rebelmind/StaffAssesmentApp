using Microsoft.EntityFrameworkCore;
using StaffAssesmentApp.Data.Context;
using StaffAssessmentApp.Helpers;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Repositories
{
    public class UserTestRepository : GenericRepository<UserTest>, IUserTestRepository
    {
        private readonly AppDbContext _context;
        public UserTestRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Result<UserTest>> GetByIdWithIncludes(int id)
        {
            var result = await _context.UserTests.Include(p => p.Test).ToListAsync();
            var ut = result.Find(z => z.Id == id);
            if (ut == null)
            {
                return Result<UserTest>.NotFound($"Entity with id {id} not found.");
            }
            return Result<UserTest>.SuccessResult(ut);
        }
    }
}
