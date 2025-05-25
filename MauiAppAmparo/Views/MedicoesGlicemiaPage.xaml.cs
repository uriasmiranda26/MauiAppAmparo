using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiAppAmparo.Views
{
    public partial class MedicoesGlicemiaPage : ContentPage
    {
        public MedicoesGlicemiaPage()
        {
            InitializeComponent();

            // Simulação de medições dos últimos dias
            lstMedicoesGlicemia.ItemsSource = new List<dynamic>
            {
                new { Detalhes = "10/05/2025  |  98 mg/dL" },
                new { Detalhes = "09/05/2025  |  105 mg/dL" },
                new { Detalhes = "08/05/2025  |  96 mg/dL" },
                new { Detalhes = "07/05/2025  |  110 mg/dL" },
                new { Detalhes = "06/05/2025  |  99 mg/dL" },
                new { Detalhes = "05/05/2025  |  115 mg/dL" },
                new { Detalhes = "04/05/2025  |  102 mg/dL" }
            };
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
