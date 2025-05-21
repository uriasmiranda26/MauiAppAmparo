using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAmparo.Models
{
    class Glicemia
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
