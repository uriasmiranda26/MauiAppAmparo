using System.Collections.ObjectModel;
using System.ComponentModel;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;

public class MedicoesGlicemiaViewModel : INotifyPropertyChanged
{
    private readonly GlicemiaService _service;
    public ObservableCollection<Glicemia> MedicoesGlicemia { get; set; }

    public MedicoesGlicemiaViewModel()
    {
        _service = new GlicemiaService();
        MedicoesGlicemia = new ObservableCollection<Glicemia>(_service.ObterGlicemiaPorIdoso(1)); // Exemplo
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}