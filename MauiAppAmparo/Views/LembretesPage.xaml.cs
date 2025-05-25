using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class LembretesPage : ContentPage
    {
        public LembretesPage()
        {
            InitializeComponent();
            BindingContext = new LembretesViewModel();
        }


        private async void OnVerLembretesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaLembretesPage());
        }

        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroLembretePage());
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
