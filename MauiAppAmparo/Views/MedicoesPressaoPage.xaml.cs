using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace MauiAppAmparo.Views
{
    public partial class MedicoesPressaoPage : ContentPage
    {
        public MedicoesPressaoPage()
        {
            InitializeComponent();

            // Simulação de medições dos últimos dias
            lstMedicoesPressao.ItemsSource = new List<dynamic>
            {
                new { Detalhes = "10/05/2025  |  120/80 mmHg" },
                new { Detalhes = "09/05/2025  |  125/82 mmHg" },
                new { Detalhes = "08/05/2025  |  118/78 mmHg" },
                new { Detalhes = "07/05/2025  |  122/81 mmHg" },
                new { Detalhes = "06/05/2025  |  119/79 mmHg" },
                new { Detalhes = "05/05/2025  |  124/80 mmHg" },
                new { Detalhes = "04/05/2025  |  126/83 mmHg" }
            };
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
