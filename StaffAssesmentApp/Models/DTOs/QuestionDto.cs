using StaffAssessmentApp.Helpers.Enums;
using System.ComponentModel.DataAnnotations;

namespace StaffAssessmentApp.Models.DTOs
{
    public class QuestionDto
    {
        //public int QuestionId { get; set; }
        //public int TestId { get; set; }
        //public string? QuestionText { get; set; }
        //public QuestionType QuestionType { get; set; }
        //public ICollection<AnswerDto>? Answers { get; set; }
        public int Id { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public QuestionType QuestionType { get; set; }

        public List<AnswerDto> Answers { get; set; } = new List<AnswerDto>();

        public int? SelectedAnswerId { get; set; }
        public List<int>? SelectedAnswerIds { get; set; } = new List<int>();
        public string? AnswerText { get; set; }
    }
}
