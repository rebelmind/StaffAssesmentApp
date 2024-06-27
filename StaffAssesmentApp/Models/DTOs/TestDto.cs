using System.ComponentModel.DataAnnotations;

namespace StaffAssessmentApp.Models.DTOs
{
    public class TestDto
    {
        //public int TestId { get; set; }
        //public string? Title { get; set; }
        //public string? Description { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public AdminDto? CreatedBy { get; set; }

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public List<QuestionDto> Questions { get; set; } = new List<QuestionDto>();
    }
}
