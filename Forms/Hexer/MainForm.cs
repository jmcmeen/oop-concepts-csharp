using System.ComponentModel;
//https://learn.microsoft.com/en-us/dotnet/csharp/asynchronous-programming/async-scenarios


namespace XX_FileDialog
{
    public partial class MainForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public byte[]? FileData { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private async void selectFileButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectFileButton.Enabled = false;

                    filePathTextBox.Text = openFileDialog.FileName;

                    outputTextBox.Text = string.Empty;

                    //IO Bound, use await without Run
                    FileData = await File.ReadAllBytesAsync(openFileDialog.FileName);

                    //CPU Bound, and not an async method, use Task.Run
                    outputTextBox.Text = await Task.Run(() => BitConverter.ToString(FileData));

                    selectFileButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}