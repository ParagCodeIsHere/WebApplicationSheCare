using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateOnly dob { get; set; }
        public DateOnly? ModifiedDate { get; set;}
        

    }
}
