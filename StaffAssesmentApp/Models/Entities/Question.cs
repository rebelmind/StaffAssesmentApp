

using StaffAssessmentApp.Helpers.Enums;

namespace StaffAssessmentApp.Models.Entities
{
    public class Question : BaseEntity
    {
        public int TestId { get; set; }
        public Test? Test { get; set; }
        public string? QuestionText { get; set; }
        public QuestionType QuestionType { get; set; }
        public ICollection<Answer>? Answers { get; set; }
    }
}
