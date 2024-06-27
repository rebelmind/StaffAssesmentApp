

using StaffAssessmentApp.Helpers;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Interfaces.Repositories
{
    public interface ITestRepository : IGenericRepository<Test>
    {
        Task<Result<Test>> GetByIdWithIncludes(int id);
    }
}
