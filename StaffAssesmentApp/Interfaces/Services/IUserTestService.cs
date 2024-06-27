using StaffAssesmentApp.Models.DTOs;
using StaffAssessmentApp.Models.DTOs;

namespace StaffAssesmentApp.Interfaces.Services
{
    public interface IUserTestService
    {
        Task<IEnumerable<UserTestDto>> GetAllUserTestsAsync();
        Task<UserTestDto> GetUserTestByIdAsync(int id);
        Task<TestResultDto> CreateUserTestAsync(UserTestDto testDto);
        Task UpdateUserTestAsync(UserTestDto testDto);
        Task DeleteUserTestAsync(int id);
    }
}
