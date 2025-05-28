
using MauiAppAmparo.ViewModels;

namespace MauiAppAmparo.Views
{
    public partial class ListaLembretesPage : ContentPage
    {
        public ListaLembretesPage()
        {
            InitializeComponent();
            BindingContext = new ListaLembretesViewModel();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
