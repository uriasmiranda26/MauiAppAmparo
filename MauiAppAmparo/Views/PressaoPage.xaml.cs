namespace MauiAppAmparo.Views
{
    public partial class PressaoPage : ContentPage
    {
        public PressaoPage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            // Aqui, futuramente, salvaremos os dados no SQLite
            await DisplayAlert("Sucesso", "Pressão arterial registrada!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
