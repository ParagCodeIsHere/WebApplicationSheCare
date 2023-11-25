using Microsoft.AspNetCore.Identity;

namespace WebApplicationSheCare.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime ModifiedDate { get; set;}
        
        public ICollection<SelectedSuggetion> selectedSuggetions { get; set;} //entity navigation property
        
    }
}
