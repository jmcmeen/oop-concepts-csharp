using TinyMVP.Presenter;
using TinyMVP.View;
using System.ComponentModel;

namespace TinyMVP
{
    public partial class MainForm : Form, IImageView
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? ImagePath { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ImagePresenter? ImagePresenter { get; set; }
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
                    ImagePresenter?.UpdateImageFile(openFileDialog.FileName);
                }
            }
        }
    }
}
