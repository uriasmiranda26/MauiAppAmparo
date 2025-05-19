using Microsoft.Maui.Controls;

namespace MauiAppAmparo.Views
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {

            DisplayAlert("Cadastro", "Usu�rio cadastrado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}
