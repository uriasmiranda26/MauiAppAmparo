namespace MauiAppAmparo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public static object Current { get; internal set; }
    }
}
