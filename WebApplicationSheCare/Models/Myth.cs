using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class Myth
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Text { get; set; }
    }
}
