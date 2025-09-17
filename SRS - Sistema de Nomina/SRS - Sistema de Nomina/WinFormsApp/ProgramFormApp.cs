namespace WinFormsApp
{
    public static class ProgramFormApp
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormApp());
        }
    }
}