using MauiAppAmparo;
using MauiAppAmparo.Models;
using MauiAppAmparo.Services;
using System.ComponentModel;
using System.Windows.Input;

public class PressaoViewModel : INotifyPropertyChanged
{
    private readonly PressaoArterialService _service;

    public string Data { get; set; }
    public string Sistolica { get; set; }
    public string Diastolica { get; set; }

    public ICommand SalvarPressaoCommand { get; }
    public ICommand VoltarCommand { get; }

    public PressaoViewModel()
    {
        _service = new PressaoArterialService();
        SalvarPressaoCommand = new Command(SalvarPressao);
        VoltarCommand = new Command(OnVoltar);
    }

    private async void SalvarPressao()
    {
        if (string.IsNullOrWhiteSpace(Data) || string.IsNullOrWhiteSpace(Sistolica) || string.IsNullOrWhiteSpace(Diastolica))
        {
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.DisplayAlert("Erro", "Todos os campos são obrigatórios.", "OK");
            }
            return;
        }

        var pressao = new PressaoArterial
        {
            DataHora = DateTime.Parse(Data),
            Sistolica = int.Parse(Sistolica),
            Diastolica = int.Parse(Diastolica),
            IdIdoso = 1 // Modificar conforme necessário
        };

        _service.AdicionarPressao(pressao);

        if (App.Current is Application appSuccess && appSuccess.MainPage != null)
        {
            await appSuccess.MainPage.DisplayAlert("Sucesso", "Registro de pressão arterial salvo!", "OK");
        }
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
