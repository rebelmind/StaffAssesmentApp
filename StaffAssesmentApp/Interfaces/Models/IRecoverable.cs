
namespace StaffAssessmentApp.Interfaces.Models {
    public interface IRecoverable {
        //string DeletedBy { get; set; }

        DateTime? DeletedDate { get; set; }

        bool IsDeleted { get; set; }
    }
}
