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
            await DisplayAlert("Informa��es", "Aqui estar�o as medi��es dos �ltimos 15 dias!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
