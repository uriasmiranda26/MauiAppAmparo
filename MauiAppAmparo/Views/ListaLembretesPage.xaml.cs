using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class ListaLembretesPage : ContentPage
    {
        public ListaLembretesPage()
        {
            InitializeComponent();

            // Simula��o de lista de lembretes
            lstLembretes.ItemsSource = new[]
            {
                new { Tipo = "Medicamento: Predinisolona", Detalhes = "09:00 AM" },

                new { Tipo = " ", Detalhes = " " }, // Espa�o em branco

                new { Tipo = "Consulta: Cardiologista", Detalhes = "Dia 25/05 �s 14:00 PM" },

                new { Tipo = " ", Detalhes = " " }, // Espa�o em branco

                new { Tipo = "Exame: Tirar sangue", Detalhes = "Dia 26/05 �s 08:30 AM" }
            };
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
