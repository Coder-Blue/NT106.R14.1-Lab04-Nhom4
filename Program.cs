namespace NT106.R14._1_Lab04_Nhom4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new NavigationMenu());
        }
    }
}
