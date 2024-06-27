
using StaffAssesmentApp.Data.Context;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>, IAnswerRepository
    {
        private readonly AppDbContext _context;
        public AnswerRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
