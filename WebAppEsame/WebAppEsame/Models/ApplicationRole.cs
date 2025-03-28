using Microsoft.AspNetCore.Identity;

namespace WebAppEsame.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> ApplicationUserRole { get; set; }
    }
}
