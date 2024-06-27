using StaffAssesmentApp.Data.Context;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Repositories
{
    public class UserAnswerRepository : GenericRepository<UserAnswer>, IUserAnswerRepository
    {
        private readonly AppDbContext _context;
        public UserAnswerRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
