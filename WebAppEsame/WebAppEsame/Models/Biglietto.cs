using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppEsame.Models
{
    public class Biglietto
    {
        public int BigliettoId { get; set; }
        [ForeignKey(nameof(Evento))]
        public int Evento { get; set; }
        public DateTime DataAcquisto
    }
}
