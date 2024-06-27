using StaffAssesmentApp.Interfaces.Services;
using StaffAssessmentApp.Interfaces.Repositories;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssesmentApp.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;
        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }
        public async Task<IEnumerable<Answer>> GetAllAnswers()
        {
            return( await _answerRepository.ListAllAsync());
            
        }
    }
}
