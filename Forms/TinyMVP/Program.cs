using TinyMVP.Model;
using TinyMVP.Presenter;

namespace TinyMVP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var model = new ImageFile();
            var view =  new MainForm();
            var presenter = new ImagePresenter(view, model);

            Application.Run(view);
        }
    }
}