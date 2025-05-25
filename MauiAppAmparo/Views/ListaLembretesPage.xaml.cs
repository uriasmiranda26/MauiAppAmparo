using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class ListaLembretesPage : ContentPage
    {
        public ListaLembretesPage()
        {
            InitializeComponent();

            // Simulação de lista de lembretes
            lstLembretes.ItemsSource = new[]
            {
                new { Tipo = "Medicamento: Predinisolona", Detalhes = "09:00 AM" },

                new { Tipo = " ", Detalhes = " " }, // Espaço em branco

                new { Tipo = "Consulta: Cardiologista", Detalhes = "Dia 25/05 às 14:00 PM" },

                new { Tipo = " ", Detalhes = " " }, // Espaço em branco

                new { Tipo = "Exame: Tirar sangue", Detalhes = "Dia 26/05 às 08:30 AM" }
            };
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
