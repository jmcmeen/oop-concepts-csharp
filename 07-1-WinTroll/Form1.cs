namespace _07_1_WinTroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.MouseEnter += new EventHandler(OnMouseEnterButton1!);
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            int x = new Random().Next(0 + button1.Width, this.Width - button1.Width * 2);
            int y = new Random().Next(0 + button1.Height, this.Height - button1.Height * 2);

            button1.Location = new Point(x, y);

        }
    }
}