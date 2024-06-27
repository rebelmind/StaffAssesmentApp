using StaffAssessmentApp.Models.DTOs;

namespace StaffAssesmentApp.Interfaces.Services
{
    public interface IUserAnswereService
    {
        Task<IEnumerable<UserAnswerDto>> GetAllUserAnswerAsync();
        Task<UserAnswerDto> GetUserAnswerByIdAsync(int id);
        Task AddUserAnswerAsync(AnswerDto userAnswerDto);
        Task UpdateUserAnswerAsync(UserAnswerDto userAnswerDto);
        Task DeleteUserAnswerAsync(int id);
    }
}
