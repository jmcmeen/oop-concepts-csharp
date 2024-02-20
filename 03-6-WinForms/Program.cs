namespace _03_6_WinForms
{
    /// <summary>
    /// Basic program showing a simple form dialog
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Form f = new Form();
            f.Text = "Hello World";
            f.ShowDialog();
        }
    }
}
