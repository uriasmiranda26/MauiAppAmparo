using MauiAppAmparo.Services;
using System.ComponentModel;
using System.Windows.Input;
using MauiAppAmparo.Models;

namespace MauiAppAmparo.ViewModels
{
    public class CadastroViewModel : INotifyPropertyChanged
    {
        private readonly UsuarioService _service;
        private readonly AppDbContext _context;

        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public ICommand CadastrarCommand { get; }

        public CadastroViewModel(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _service = new UsuarioService(_context);
            CadastrarCommand = new Command(CadastrarUsuario);
        }

        public CadastroViewModel()
        {
        }

        private void CadastrarUsuario()
        {
            // Implementation for user registration  
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}