using MauiAppAmparo.ViewModels;

namespace MauiAppAmparo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(LoginViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }


        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Aqui futuramente será validado o login
            await Navigation.PushAsync(new MenuPage());
        }

        private async void OnCadastroClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());
        }
    }
}
