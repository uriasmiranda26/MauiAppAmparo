namespace MauiAppAmparo
{
    public partial class App : Application
    {
        public App()
        {

            MainPage = new AppShell();
        }

        public static object Current { get; internal set; }
    }
}
