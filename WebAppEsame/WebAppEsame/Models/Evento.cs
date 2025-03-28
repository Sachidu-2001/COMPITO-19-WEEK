using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppEsame.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Titolo { get; set; }
        public DateTime Data {  get; set; }
        public string Luogo {  get; set; }

        [Required]
        public int ArtistaId { get; set; }
        [ForeignKey(nameof(ArtistaId))]
        public Artista Artista { get; set; }

        public ICollection<Biglietto> Biglietti { get; set; } = new List<Biglietto>();
    }
}
