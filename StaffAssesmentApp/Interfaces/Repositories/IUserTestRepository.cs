

using StaffAssessmentApp.Helpers;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Interfaces.Repositories
{
    public interface IUserTestRepository : IGenericRepository<UserTest>
    {
        Task<Result<UserTest>> GetByIdWithIncludes(int id);
    }
}
