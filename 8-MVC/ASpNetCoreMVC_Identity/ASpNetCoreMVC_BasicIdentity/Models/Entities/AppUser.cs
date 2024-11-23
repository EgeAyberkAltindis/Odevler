using Microsoft.AspNetCore.Identity;

namespace ASpNetCoreMVC_BasicIdentity.Models.Entities
{
    public class AppUser:IdentityUser
    {
        //Address
        public string? Address { get; set; }

        //Birthdate
        public DateTime? Birthdate { get; set; }

    }
}
