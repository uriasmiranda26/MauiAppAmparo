using MauiAppAmparo.Services;
using MauiAppAmparo.Views;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiAppAmparo.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly UsuarioService _service;

        public string Usuario { get; set; } = string.Empty; // Fix for CS8618  
        public string Senha { get; set; } = string.Empty;   // Fix for CS8618  

        public ICommand LoginCommand { get; }
        public ICommand CadastroCommand { get; }

        public LoginViewModel(AppDbContext context) // Updated constructor to accept AppDbContext  
        {
            _service = new UsuarioService(context); // Pass context to UsuarioService  
            LoginCommand = new Command(OnLogin);
            CadastroCommand = new Command(OnCadastro);
        }

        private async void OnLogin()
        {
            var usuario = _service.AutenticarUsuario(Usuario, Senha);

            if (usuario != null)
            {
                if (App.Current is Application app && app.MainPage != null) // Fix for CS1061
                {
                    await app.MainPage.DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");
                    await app.MainPage.Navigation.PushAsync(new InformacoesPage());
                }
            }
            else
            {
                if (App.Current is Application app && app.MainPage != null) // Fix for CS1061
                {
                    await app.MainPage.DisplayAlert("Erro", "Usuário ou senha incorretos.", "OK");
                }
            }
        }

        private async void OnCadastro()
        {
            if (App.Current is Application app && app.MainPage != null) // Fix for CS1061
            {
                await app.MainPage.Navigation.PushAsync(new CadastroPage());
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged; // Fix for CS8618  
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}