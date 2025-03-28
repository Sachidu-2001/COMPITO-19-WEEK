using System.ComponentModel.DataAnnotations;

namespace WebAppEsame.Models
{
    public class Artista
    {
        [Key]
        public int Artista {  get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Genere { get; set; }
        [Required]
        public string Biografia { get; set; }

    }
}
