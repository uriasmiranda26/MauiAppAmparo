using MauiAppAmparo.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class ContatoEmergenciaPage : ContentPage
    {
        public ContatoEmergenciaPage()
        {
            InitializeComponent();
            BindingContext = new ContatoEmergenciaViewModel();
        }



        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
