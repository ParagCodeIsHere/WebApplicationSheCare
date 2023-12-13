using Microsoft.AspNetCore.Identity;

namespace WebApplicationSheCare.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime ModifiedDate { get; set;}
        
        public IList<Suggetion> UserSuggetions { get; set;} //entity navigation property
        
    }
}
