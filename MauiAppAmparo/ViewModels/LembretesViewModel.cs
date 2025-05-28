using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using MauiAppAmparo.Views;
using Microsoft.Maui.Controls;

namespace MauiAppAmparo.ViewModels
{
    public class LembretesViewModel : INotifyPropertyChanged
    {
        private readonly LembreteService _service;

        public ObservableCollection<Lembrete> Lembretes { get; set; }

        public ICommand VerLembretesCommand { get; }
        public ICommand AdicionarLembreteCommand { get; }
        public ICommand VoltarCommand { get; }

        public LembretesViewModel()
        {
            _service = new LembreteService();
            Lembretes = new ObservableCollection<Lembrete>(_service.ObterLembretesPendentes());

            VerLembretesCommand = new Command(ObterLembretes);
            AdicionarLembreteCommand = new Command(OnAdicionarLembrete);
            VoltarCommand = new Command(OnVoltar);
        }

        private void ObterLembretes()
        {
            Lembretes.Clear();
            var lembretes = _service.ObterLembretesPendentes();
            foreach (var lembrete in lembretes)
            {
                Lembretes.Add(lembrete);
            }
            OnPropertyChanged(nameof(Lembretes));
        }

        private async void OnAdicionarLembrete()
        {
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PushAsync(new CadastroLembretePage());
            }
        }

        private async void OnVoltar()
        {
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PopAsync();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged; // Marked as nullable to fix CS8618
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}