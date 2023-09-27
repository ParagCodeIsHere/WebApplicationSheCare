using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class RegisterView
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",
            ErrorMessage ="Password & Confirmation Password do not match!")]
        public string ConfirmPassword { get; set; }
    }
}
