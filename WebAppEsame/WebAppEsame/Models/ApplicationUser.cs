using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace WebAppEsame.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }

        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new List<ApplicationUserRole>();
        public ICollection<Artista> Artisti { get; set; } = new List<Artista>();
    }

}

