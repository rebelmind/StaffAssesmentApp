namespace StaffAssessmentApp.Models.Entities
{
    public class Answer : BaseEntity
    {
        public int QuestionId { get; set; }
        public Question? Question { get; set; }
        public string? AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
