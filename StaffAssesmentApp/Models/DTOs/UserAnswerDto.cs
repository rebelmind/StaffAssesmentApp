namespace StaffAssessmentApp.Models.DTOs
{
    public class UserAnswerDto
    {
        public int UserAnswerId { get; set; }
        public int UserTestId { get; set; }
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public string? AnswerText { get; set; }
    }
}
