using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAmparo.ViewModels
{
    public class IdosoViewModel : INotifyPropertyChanged
    {
        private readonly IdosoService _service;
        public ObservableCollection<Idoso> Idosos { get; set; }

        public IdosoViewModel()
        {
            _service = new IdosoService();
            Idosos = new ObservableCollection<Idoso>(_service.ObterTodosIdosos());
        }

        public void AdicionarIdoso(DateTime dataNascimento, string contatoEmergencia)
        {
            var idoso = new Idoso { DataNascimento = dataNascimento, ContatoEmergencia = contatoEmergencia };
            _service.AdicionarIdoso(idoso);
            Idosos.Add(idoso);
            OnPropertyChanged(nameof(Idosos));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
