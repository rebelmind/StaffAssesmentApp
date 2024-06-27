using StaffAssesmentApp.Data.Context;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Repositories
{
    public class QuestionRepository : GenericRepository<Question>, IQestionRepository
    {
        private readonly AppDbContext _context;
        public QuestionRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
