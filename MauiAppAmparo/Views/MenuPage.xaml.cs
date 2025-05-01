namespace MauiAppAmparo.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OnPressaoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PressaoPage());
        }

        private async void OnGlicemiaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlicemiaPage());
        }

        private async void OnLembretesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LembretesPage());
        }

        private async void OnInformacoesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InformacoesPage());
        }

        private async void OnContatoClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContatoPage());
        }
    }
}
