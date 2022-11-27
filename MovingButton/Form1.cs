namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var number = rnd.NextInt64(-100, 100);
            var number2 = rnd.NextInt64(-100, 100);
            this.magicButton.Location = new Point(312 + (int)number, 197 + (int)number2);
        }
    }
}