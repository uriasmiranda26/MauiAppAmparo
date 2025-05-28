using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Services;
using MauiAppAmparo.Models;

namespace MauiAppAmparo.ViewModels
{
    public class ContatoEmergenciaViewModel : INotifyPropertyChanged
    {
        private readonly ContatoEmergenciaService _service;

        public string Nome { get; set; } = string.Empty; // Fix for CS8618
        public string Celular { get; set; } = string.Empty; // Fix for CS8618
        public string Parentesco { get; set; } = string.Empty; // Fix for CS8618

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
                if (App.Current is Application app && app.MainPage != null)
                {
                    await app.MainPage.DisplayAlert("Erro", "Todos os campos são obrigatórios.", "OK");
                }
                return;
            }

            var contato = new ContatoEmergencia { Nome = Nome, Telefone = Celular, Relacao = Parentesco };
            _service.AdicionarContato(contato);

            if (App.Current is Application appSuccess && appSuccess.MainPage != null)
            {
                await appSuccess.MainPage.DisplayAlert("Sucesso", "Contato salvo com sucesso!", "OK");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged; // Fix for CS8618
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}