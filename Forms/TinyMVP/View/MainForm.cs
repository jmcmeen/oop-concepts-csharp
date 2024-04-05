using TinyMVP.Presenter;
using TinyMVP.View;

namespace TinyMVP
{
    public partial class MainForm : Form, IImageView
    {
        public string ImagePath { get; set; }
        public ImagePresenter ImagePresenter { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.ImageLocation = this.ImagePath;
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog.CheckFileExists = true;
            openFileDialog.Filter = "PNG files (*.png)|*.png";
            openFileDialog.DefaultExt = ".png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    this.ImagePresenter.UpdateImageFile(openFileDialog.FileName);
                }
            }
        }
    }
}
