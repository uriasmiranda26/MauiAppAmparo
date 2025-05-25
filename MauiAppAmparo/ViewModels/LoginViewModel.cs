using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using MauiAppAmparo.Views;
using Microsoft.Maui.Controls;

public class LoginViewModel : INotifyPropertyChanged
{
    private readonly UsuarioService _service;

    public string Usuario { get; set; }
    public string Senha { get; set; }

    public ICommand LoginCommand { get; }
    public ICommand CadastroCommand { get; }

    public LoginViewModel()
    {
        _service = new UsuarioService();
        LoginCommand = new Command(OnLogin);
        CadastroCommand = new Command(OnCadastro);
    }

    private async void OnLogin()
    {
        var usuario = _service.AutenticarUsuario(Usuario, Senha);

        if (usuario != null)
        {
            await App.Current.MainPage.DisplayAlert("Sucesso", "Login realizado com sucesso!", "OK");
            await App.Current.MainPage.Navigation.PushAsync(new InformacoesPage());
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Erro", "Usuário ou senha incorretos.", "OK");
        }
    }

    private async void OnCadastro()
    {
        await App.Current.MainPage.Navigation.PushAsync(new CadastroPage());
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}