using StaffAssessmentApp.Models.DTOs;

namespace StaffAssesmentApp.Interfaces.Services
{
    public interface ICalculateResultService
    {
        Task<int> CalculateScore(UserTestDto model);
    }
}
