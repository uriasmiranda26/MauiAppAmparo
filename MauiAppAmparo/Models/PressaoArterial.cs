namespace MauiAppAmparo.Models
{
    public class PressaoArterial
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public decimal Valor { get; set; }
        public int IdIdoso { get; set; }
        public Idoso Idoso { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        // Adicionando as propriedades Sistolica e Diastolica para corrigir os erros CS0117  
        public int Sistolica { get; set; }
        public int Diastolica { get; set; }
    }
}
