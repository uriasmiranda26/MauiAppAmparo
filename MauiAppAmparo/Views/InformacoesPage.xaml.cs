namespace MauiAppAmparo.Views
{
    public partial class InformacoesPage : ContentPage
    {
        public InformacoesPage()
        {
            InitializeComponent();
        }

        private async void OnVerMedicoesClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Informações", "Aqui estarão as medições dos últimos 15 dias!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
