using System.Windows.Input;
using MauiAppAmparo;
using MauiAppAmparo.Views;
using Microsoft.Maui.Controls;

namespace MauiAppAmparo.ViewModels
{
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
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PushAsync(new ContatoPage());
            }
        }

        private async void OnVerMedicoesPressao()
        {
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PushAsync(new PressaoPage());
            }
        }

        private async void OnVerMedicoesGlicemia()
        {
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PushAsync(new GlicemiaPage());
            }
        }

        private async void OnVoltar()
        {
            if (App.Current is Application app && app.MainPage != null)
            {
                await app.MainPage.Navigation.PopAsync();
            }
        }
    }
}