using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppEsame.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Titolo { get; set; }
        public DateTime Data {  get; set; }
        public string Luogo {  get; set; }
        [ForeignKey(nameof(Artista))]
        public int Artista { get; set; }
    }
}
