using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using Microsoft.Maui.Controls;

namespace MauiAppAmparo.ViewModels
{
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
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PopAsync();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}