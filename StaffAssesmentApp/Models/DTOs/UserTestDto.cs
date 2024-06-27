namespace StaffAssessmentApp.Models.DTOs
{
    public class UserTestDto
    {
        public int UserTestId { get; set; }
        public string UserId { get; set; }
        public int TestId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Score { get; set; }
        public TestDto? Test { get; set; }
    }
}
