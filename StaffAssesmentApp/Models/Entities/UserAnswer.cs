namespace StaffAssessmentApp.Models.Entities
{
    public class UserAnswer : BaseEntity
    {
        public int UserTestId { get; set; }
        public UserTest? UserTest { get; set; }
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
        public int? AnswerId { get; set; }
        public Answer? Answer { get; set; }
        public string? AnswerText { get; set; }
    }
}
