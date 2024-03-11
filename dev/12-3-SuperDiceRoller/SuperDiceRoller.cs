namespace XX_Test
{
    public partial class SuperDiceRoller : Form
    {
        public SuperDiceRoller()
        {
            InitializeComponent();
        }

        private void d4_Click(object sender, EventArgs e)
        {
            output.Text = $"d4 = {DiceRoller.Roll(4)}";
        }

        private void d6_Click(object sender, EventArgs e)
        {
            output.Text = $"d6 = {DiceRoller.Roll(6)}";
        }

        private void d8_Click(object sender, EventArgs e)
        {
            output.Text = $"d8 = {DiceRoller.Roll(8)}";
        }

        private void d10_Click(object sender, EventArgs e)
        {
            output.Text = $"d10 = {DiceRoller.Roll(10)}";
        }

        private void d12_Click(object sender, EventArgs e)
        {
            output.Text = $"d12 = {DiceRoller.Roll(12)}";
        }

        private void d20_Click(object sender, EventArgs e)
        {
            output.Text = $"d20 = {DiceRoller.Roll(20)}";
        }
        private void d100_Click(object sender, EventArgs e)
        {
            output.Text = $"d100 = {DiceRoller.Roll(100)}";
        }

        private void dx_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = $"d{x.Text} = {DiceRoller.Roll(Int32.Parse(x.Text))}";
            }
            catch (FormatException)
            {
                output.Text = $"Error!";
            }
        }

        private void x_TextChanged(object sender, EventArgs e)
        {
            dx.Text = $"d{x.Text}";
        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}