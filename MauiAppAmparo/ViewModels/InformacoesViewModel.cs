using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Views;
using Microsoft.Maui.Controls;

public class InformacoesViewModel
{
    public ICommand VerContatoEmergenciaCommand { get; }
    public ICommand VerMedicoesPressaoCommand { get; }
    public ICommand VerMedicoesGlicemiaCommand { get; }
    public ICommand VoltarCommand { get; }

    public InformacoesViewModel()
    {
        VerContatoEmergenciaCommand = new Command(OnVerContatoEmergencia);
        VerMedicoesPressaoCommand = new Command(OnVerMedicoesPressao);
        VerMedicoesGlicemiaCommand = new Command(OnVerMedicoesGlicemia);
        VoltarCommand = new Command(OnVoltar);
    }

    private async void OnVerContatoEmergencia()
    {
        await App.Current.MainPage.Navigation.PushAsync(new ContatoPage());
    }

    private async void OnVerMedicoesPressao()
    {
        await App.Current.MainPage.Navigation.PushAsync(new PressaoArterialPage());
    }

    private async void OnVerMedicoesGlicemia()
    {
        await App.Current.MainPage.Navigation.PushAsync(new GlicemiaPage());
    }

    private async void OnVoltar()
    {
        await App.Current.MainPage.Navigation.PopAsync();
    }
}