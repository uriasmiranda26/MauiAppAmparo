using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MauiAppAmparo.Models
{
    public class Glicemia
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }

        public int IdIdoso { get; set; }
        [ForeignKey("IdIdoso")]
        public Idoso Idoso { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }
    }
}
