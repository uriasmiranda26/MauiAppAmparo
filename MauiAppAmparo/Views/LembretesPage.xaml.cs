using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class LembretesPage : ContentPage
    {
        public LembretesPage()
        {
            InitializeComponent();
        }

        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroLembretePage());

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
