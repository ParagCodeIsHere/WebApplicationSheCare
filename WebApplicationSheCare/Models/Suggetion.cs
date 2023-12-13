using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationSheCare.Models
{
    public class Suggetion
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string Answer{ get; set; }
        public bool IsActive { get; set; }
        //public ICollection<SelectedSuggetion> selectedSuggetions { get; set; } //entity navigation property

    }
}
