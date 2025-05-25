using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiAppAmparo.Views
{
    public partial class MedicoesPressaoPage : ContentPage
    {
        public MedicoesPressaoPage()
        {
            InitializeComponent();
            BindingContext = new MedicoesPressaoViewModel();
        }


        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
