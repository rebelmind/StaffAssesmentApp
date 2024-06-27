using StaffAssessmentApp.Models.DTOs;

namespace StaffAssesmentApp.Interfaces.Services
{
    public interface ITestService
    {
        Task<IEnumerable<TestDto>> GetAllTestsAsync();
        Task<TestDto> GetTestByIdAsync(int id);
        Task AddTestAsync(TestDto testDto);
        Task UpdateTestAsync(TestDto testDto);
        Task DeleteTestAsync(int id);

        Task<UserTestDto> GetUserTestDtoByTest();
    }
}
