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
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        private readonly UsuarioService _service;
        public ObservableCollection<Usuario> Usuarios { get; set; }

        public UsuarioViewModel()
        {
            _service = new UsuarioService();
            Usuarios = new ObservableCollection<Usuario>(_service.ObterTodosUsuarios());
        }

        public void AdicionarUsuario(string nome, string email, string senha)
        {
            var usuario = new Usuario { Nome = nome, Email = email, Senha = senha };
            _service.AdicionarUsuario(usuario);
            Usuarios.Add(usuario);
            OnPropertyChanged(nameof(Usuarios));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
