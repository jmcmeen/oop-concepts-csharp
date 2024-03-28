namespace _11_2_ModelViewPresenter
{
    /// <summary>
    /// Demonstrates Design Patterns
    ///     * Model View Presenter
    ///     * Repository
    /// Adapted from: https://github.com/mrts/winforms-mvp
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new Model.SpeciesXmlRepository(Application.StartupPath);
            var view = new View.SpeciesForm();

            // Poor Man's Dependency Injection/Pure Dependency Injection, Main() is the Composition Root.
            // See https://github.com/mrts/winforms-mvp/issues/2.
            var presenter = new Presenter.SpeciesPresenter(view, repository);

            Application.Run(view);
        }
    }
}
