using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiAppAmparo.ViewModels
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        private readonly UsuarioService _service;
        public ObservableCollection<Usuario> Usuarios { get; set; }

        public UsuarioViewModel(AppDbContext context)
        {
            _service = new UsuarioService(context);
            Usuarios = new ObservableCollection<Usuario>(_service.ObterTodosUsuarios());
        }

        public void AdicionarUsuario(string nome, string email, string senha)
        {
            var usuario = new Usuario { Nome = nome, Email = email, Senha = senha };
            _service.AdicionarUsuario(usuario);
            Usuarios.Add(usuario);
            OnPropertyChanged(nameof(Usuarios));
        }

        public event PropertyChangedEventHandler? PropertyChanged; // Marked as nullable to fix CS8618
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
