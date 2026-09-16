using System.ComponentModel.DataAnnotations;

namespace AspDotNetCoreAuthAndAuth.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The password must be at least 6 character long", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password mismatch")]
        public string ConfirmPassword { get; set; }
    }
}
