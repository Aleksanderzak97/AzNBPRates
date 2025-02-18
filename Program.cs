using AzNBPRates.Presenters;

namespace AzNBPRates
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm view = new MainForm();
            RatePresenter presenter = new RatePresenter(view);

            Application.Run(view);
        }
    }
}