namespace MauiAppAmparo.Views
{
    public partial class GlicemiaPage : ContentPage
    {
        public GlicemiaPage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso", "Índice glicêmico registrado!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
