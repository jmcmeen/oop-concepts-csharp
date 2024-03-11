namespace _00_1_HelloForms
{
    /// <summary>
    /// Main form for Hello Forms App
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// MainForm constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Sets the fortune label to blank.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            fortuneLabel.Text = "";
        }

        /// <summary>
        /// Sets the fortune label to random fortune.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void revealFortuneButton_Click(object sender, EventArgs e)
        {
            var fortunes = new List<string> { "Hello World!",
                                              "Welcome to Object-Oriented Programming Concepts!",
                                              "Stay awhile, and listen!",
                                              "Every puzzle has an answer.",
                                              "Leroy Jenkins!",
                                              "It's dangerous to go alone! Take this!",
                                              "The cake is a lie!"};
                    

            fortuneLabel.Text = fortunes[new Random().Next(fortunes.Count)];
        }
    }
}
