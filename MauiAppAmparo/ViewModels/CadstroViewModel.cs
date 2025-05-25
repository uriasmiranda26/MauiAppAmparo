using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using Microsoft.Maui.Controls;

public class CadastroViewModel : INotifyPropertyChanged
{
    private readonly UsuarioService _service;

    public string Nome { get; set; }
    public string Celular { get; set; }
    public string Senha { get; set; }
    public string ConfirmarSenha { get; set; }

    public ICommand CadastrarCommand { get; }

    public CadastroViewModel()
    {
        _service = new UsuarioService();
        CadastrarCommand = new Command(CadastrarUsuario);
    }

    private async void CadastrarUsuario()
    {
        if (Senha != ConfirmarSenha)
        {
            await App.Current.MainPage.DisplayAlert("Erro", "As senhas não coincidem.", "OK");
            return;
        }

        var usuario = new Usuario { Nome = Nome, Email = $"{Celular}@email.com", Senha = Senha };
        _service.AdicionarUsuario(usuario);

        await App.Current.MainPage.DisplayAlert("Sucesso", "Cadastro realizado com sucesso!", "OK");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}