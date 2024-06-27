namespace StaffAssesmentApp.Models.DTOs
{
    public class TestResultDto
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string TestName { get; set; }
        public string Descr { get; set; }
    }
}
