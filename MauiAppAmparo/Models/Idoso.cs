using System.ComponentModel.DataAnnotations;

namespace MauiAppAmparo.Models
{
    public class Idoso
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string ContatoEmergencia { get; set; }
    }
}
