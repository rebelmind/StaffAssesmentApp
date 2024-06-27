using StaffAssessmentApp.Models.Entities;

namespace StaffAssesmentApp.Interfaces.Services
{
    public interface IAnswerService
    {
        Task<IEnumerable<Answer>> GetAllAnswers();
    }
}
