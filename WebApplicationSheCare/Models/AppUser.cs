using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display (Name= "Date Of Birth")]
        public DateTime dob { get; set; }
        [Display(Name = "Last Period On")]
        public DateTime ModifiedDate { get; set;}
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public Int64 Phone { get; set; }
    }
}
