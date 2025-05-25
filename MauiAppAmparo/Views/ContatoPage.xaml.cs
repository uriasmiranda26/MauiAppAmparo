namespace MauiAppAmparo.Views
{
    public partial class ContatoPage : ContentPage
    {
        public ContatoPage()
        {
            InitializeComponent();
            BindingContext = new ContatoEmergenciaViewModel();
        }


        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso", "Contato de emergência salvo!", "OK");
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
