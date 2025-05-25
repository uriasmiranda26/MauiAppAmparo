using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using Microsoft.Maui.Controls;

public class ListaLembretesViewModel : INotifyPropertyChanged
{
    private readonly LembreteService _service;
    public ObservableCollection<Lembrete> Lembretes { get; set; }

    public ICommand VoltarCommand { get; }

    public ListaLembretesViewModel()
    {
        _service = new LembreteService();
        Lembretes = new ObservableCollection<Lembrete>(_service.ObterLembretesPendentes());

        VoltarCommand = new Command(OnVoltar);
    }

    private async void OnVoltar()
    {
        await App.Current.MainPage.Navigation.PopAsync();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}