using _04_8_CircleClaculator;

namespace _04_8_CircleCalculator
{
    /// <summary>
    /// Circle Calculator
    /// </summary>
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
            ApplicationConfiguration.Initialize();
            Application.Run(new CircleForm());
        }
    }
}