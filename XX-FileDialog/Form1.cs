using System.Security;
using System.Text;

namespace XX_FileDialog
{
    public partial class Form1 : Form
    {
        public byte[] fileData { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
                fileData = File.ReadAllBytes(openFileDialog.FileName);

                outputTextBox.Text = BitConverter.ToString(fileData);
            }
        }
    }
}