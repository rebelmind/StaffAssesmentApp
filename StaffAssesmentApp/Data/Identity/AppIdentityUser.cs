using Microsoft.AspNetCore.Identity;

namespace StaffAssesmentApp.Data.Identity
{
    public class AppIdentityUser : IdentityUser
    {
        public string Department { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty ;
        public int Score { get; set; }
    }
}
