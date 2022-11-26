namespace HeightCalculator
{
    public partial class HeightCalculator : Form
    {

        public HeightCalculator()
        {
            InitializeComponent();
        }

        public class MessageBoxManager
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your height is {textBox1.Text} cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}