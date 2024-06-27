using StaffAssesmentApp.Data.Identity;

namespace StaffAssessmentApp.Models.Entities
{
    public class Test : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public AppIdentityUser? CreatedByUser { get; set; }
        public ICollection<Question>? Questions { get; set; }
        public ICollection<UserTest>? UserTests { get; set; }
    }
}
