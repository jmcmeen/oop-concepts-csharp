namespace XX_BasicWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.MouseEnter += OnMouseEnterButton1;
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            int x = new Random().Next(0 + button1.Width, this.Width - button1.Width);
            int y = new Random().Next(0 + button1.Height, this.Height - button1.Height);

            button1.Location = new Point(x, y);
            
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}