namespace XX_BindingSource
{
    public partial class Form1 : Form
    {
        public List<string> stringList;
        public Form1()
        {
            InitializeComponent();
            stringList = new List<string>();

            listBindingSource.DataSource = stringList;
            stringListBox.DataSource = listBindingSource;
        }

        private void addStringButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text != "" || inputTextBox.Text != null)
            {
                stringList.Add(inputTextBox.Text);
                inputTextBox.Clear();
                listBindingSource.ResetBindings(false);
            }
        }
    }
}