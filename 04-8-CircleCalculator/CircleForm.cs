namespace CircleCalculator
{
    /// <summary>
    /// Main Form
    /// </summary>
    public partial class CircleForm : Form
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public CircleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Action for radiusTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (radiusTextBox.Text != "")
            {
                float radius = Convert.ToSingle(radiusTextBox.Text);

                areaTextBox.Text = CircleHelper.CalculateCircleArea(radius).ToString();
            }
        }

        /// <summary>
        /// Action for areaTextBox TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void areaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (areaTextBox.Text != "" && areaTextBox.Text is not null)
            {
                float area = Convert.ToSingle(areaTextBox.Text);

                radiusTextBox.Text = CircleHelper.CalculateCircleRadius(area).ToString();
            }
        }
    }
}
