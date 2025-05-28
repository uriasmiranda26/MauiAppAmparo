using System.Collections.ObjectModel;
using System.ComponentModel;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;

namespace MauiAppAmparo.ViewModels
{
    public class MedicoesPressaoViewModel : INotifyPropertyChanged
    {
        private readonly PressaoArterialService _service;
        public ObservableCollection<PressaoArterial> MedicoesPressao { get; set; }

        public MedicoesPressaoViewModel()
        {
            _service = new PressaoArterialService();
            MedicoesPressao = new ObservableCollection<PressaoArterial>(_service.ObterPressaoPorIdoso(1)); // Exemplo  
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}