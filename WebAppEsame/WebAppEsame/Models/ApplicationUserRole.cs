using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace WebAppEsame.Models
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        [ForeignKey("RoleId")]
        public ApplicationRole Role { get; set; }

    }
}
