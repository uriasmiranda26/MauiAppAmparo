using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class CadastroLembretePage : ContentPage
    {
        public CadastroLembretePage()
        {
            InitializeComponent();
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            // Verifica se o usuário preencheu um dos grupos corretamente
            bool medicamentoPreenchido = !string.IsNullOrEmpty(txtNomeMedicamento.Text) && !string.IsNullOrEmpty(txtHorarioMedicamento.Text);
            bool consultaPreenchida = !string.IsNullOrEmpty(txtTipoConsultaExame.Text) && !string.IsNullOrEmpty(txtDataConsulta.Text) && !string.IsNullOrEmpty(txtHorarioConsulta.Text);

            if (medicamentoPreenchido || consultaPreenchida)
            {
                if (medicamentoPreenchido)
                {
                    var lembreteMedicamento = new
                    {
                        Tipo = "Medicamento: " + txtNomeMedicamento.Text,
                        Detalhes = txtHorarioMedicamento.Text
                    };

                    await DisplayAlert("Lembrete", "Medicamento salvo com sucesso!", "OK");
                }
                else
                {
                    var lembreteConsulta = new
                    {
                        Tipo = txtTipoConsultaExame.Text,
                        Detalhes = txtDataConsulta.Text + " às " + txtHorarioConsulta.Text
                    };

                    await DisplayAlert("Lembrete", "Consulta/Exame salvo com sucesso!", "OK");
                }

                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Erro", "Preencha os campos de Medicamento ou de Consulta/Exame antes de salvar!", "OK");
            }
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
