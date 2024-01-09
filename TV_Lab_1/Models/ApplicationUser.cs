using Microsoft.AspNetCore.Identity;
using TV_Lab_1.Data;

namespace TV_Lab_1.Models
{
    public class ApplicationUser : IdentityUser

    {
        //public byte[] Avatar { get; set; }    
        public static implicit operator ApplicationUser?(ApplicationDbContext? v)
        {
            throw new NotImplementedException();
        }
    }
}
