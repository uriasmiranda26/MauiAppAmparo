using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Services;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using Microsoft.Maui.Controls;

public class ContatoEmergenciaViewModel : INotifyPropertyChanged
{
    private readonly ContatoEmergenciaService _service;

    public string Nome { get; set; }
    public string Celular { get; set; }
    public string Parentesco { get; set; }

    public ICommand SalvarContatoCommand { get; }

    public ContatoEmergenciaViewModel()
    {
        _service = new ContatoEmergenciaService();
        SalvarContatoCommand = new Command(SalvarContato);
    }

    private async void SalvarContato()
    {
        if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Celular) || string.IsNullOrWhiteSpace(Parentesco))
        {
            await App.Current.MainPage.DisplayAlert("Erro", "Todos os campos são obrigatórios.", "OK");
            return;
        }

        var contato = new ContatoEmergencia { Nome = Nome, Telefone = Celular, Relacao = Parentesco };
        _service.AdicionarContato(contato);

        await App.Current.MainPage.DisplayAlert("Sucesso", "Contato salvo com sucesso!", "OK");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}