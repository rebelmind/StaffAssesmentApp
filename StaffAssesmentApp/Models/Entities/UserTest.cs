using StaffAssesmentApp.Data.Identity;

namespace StaffAssessmentApp.Models.Entities
{

    public class UserTest : BaseEntity
    {
        public string AppUserId { get; set; }
        public AppIdentityUser? User { get; set; }
        public int TestId { get; set; }
        public Test? Test { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Score { get; set; }
    }
}
