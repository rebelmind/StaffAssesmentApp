namespace StaffAssessmentApp.Models.DTOs
{
    public class AnswerDto
    {
        //public int AnswerId { get; set; }
        //public string? AnswerText { get; set; }
        //public bool IsCorrect { get; set; }
        public int Id { get; set; }
        public string AnswerText { get; set; }

        public bool IsCorrect { get; set; }
    }
}
