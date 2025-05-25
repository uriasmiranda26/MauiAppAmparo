using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class InformacoesPage : ContentPage
    {
        public InformacoesPage()
        {
            InitializeComponent();
        }

        private async void OnVerContatoEmergenciaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContatoEmergenciaPage());
        }

        private async void OnVerMedicoesPressaoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicoesPressaoPage());
        }

        private async void OnVerMedicoesGlicemiaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicoesGlicemiaPage());
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
