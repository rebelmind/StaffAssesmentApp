using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Interfaces
{
    public interface IResult<T> where T : BaseEntity
    {
        bool Success { get; }
        T Data { get; }
        string ErrorMessage { get; }
    }
}
