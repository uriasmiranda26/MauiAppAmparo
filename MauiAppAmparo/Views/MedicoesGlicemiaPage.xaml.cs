using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiAppAmparo.Views
{
    public partial class MedicoesGlicemiaPage : ContentPage
    {
        public MedicoesGlicemiaPage()
        {
            InitializeComponent();
            BindingContext = new MedicoesGlicemiaViewModel();
        }


        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
