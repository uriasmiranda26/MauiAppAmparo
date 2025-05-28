using MauiAppAmparo.ViewModels;

namespace MauiAppAmparo.Views
{
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
            BindingContext = new CadastroViewModel();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {

            DisplayAlert("Cadastro", "Usuário cadastrado com sucesso!", "OK");
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }
    }
}


