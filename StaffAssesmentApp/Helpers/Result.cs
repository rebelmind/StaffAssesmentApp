
using StaffAssessmentApp.Interfaces;
using StaffAssessmentApp.Models.Entities;

namespace StaffAssessmentApp.Helpers
{
    public class Result<T> : IResult<T> where T : BaseEntity
    {
        public bool Success { get; private set; }
        public T Data { get; private set; }
        public string? ErrorMessage { get; private set; }

 

        private Result() {}

        public static Result<T> NotFound(string errorMessage)
        {
            return new Result<T> { Success = false, ErrorMessage = errorMessage };
        }

        public static Result<T> SuccessResult(T data)
        {
            return new Result<T> { Success = true, Data = data };
        }

        
    }
}
