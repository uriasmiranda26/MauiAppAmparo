namespace MauiAppAmparo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                System.Diagnostics.Debug.WriteLine($"ERRO NÃO TRATADO: {e.ExceptionObject}");
            };
            MainPage = new MainPage();
        }

        public static object Current { get; internal set; }
    }
}
