using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class Suggetion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer{ get; set; }
    }
}
