using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using Microsoft.Maui.Controls;

public class GlicemiaViewModel : INotifyPropertyChanged
{
    private readonly GlicemiaService _service;

    public string Data { get; set; }
    public string Medicao { get; set; }

    public ICommand SalvarGlicemiaCommand { get; }

    public ObservableCollection<Glicemia> Glicemias { get; set; }

    public GlicemiaViewModel()
    {
        _service = new GlicemiaService();
        Glicemias = new ObservableCollection<Glicemia>(_service.ObterGlicemiaPorIdoso(1)); // Exemplo

        SalvarGlicemiaCommand = new Command(SalvarGlicemia);
    }

    private async void SalvarGlicemia()
    {
        if (string.IsNullOrWhiteSpace(Data) || string.IsNullOrWhiteSpace(Medicao))
        {
            await App.Current.MainPage.DisplayAlert("Erro", "Todos os campos são obrigatórios.", "OK");
            return;
        }

        var glicemia = new Glicemia
        {
            DataHora = DateTime.Parse(Data),
            Valor = int.Parse(Medicao),
            IdIdoso = 1 // Modificar conforme necessário
        };

        _service.AdicionarGlicemia(glicemia);
        Glicemias.Add(glicemia);

        await App.Current.MainPage.DisplayAlert("Sucesso", "Registro de glicemia salvo!", "OK");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}