using StaffAssessmentApp.Helpers.Enums;
using System.ComponentModel.DataAnnotations;

namespace StaffAssessmentApp.Models.DTOs
{
    public class UserDto
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
        //public UserRole Role { get; set; }
        public int AdminCode { get; set; }
    }
}
