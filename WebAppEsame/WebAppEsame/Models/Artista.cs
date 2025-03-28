using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppEsame.Models
{
    public class Artista
    {
        [Key]
        public int ArtistaId {  get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Genere { get; set; }
        [Required]
        public string Biografia { get; set; }

        [ForeignKey("UserId")]    
        public ApplicationUser User { get; set; }
    }
}
