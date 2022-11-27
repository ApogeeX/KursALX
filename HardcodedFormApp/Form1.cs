namespace HardcodedFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardcodedButton = new Button();
            HardcodedButton.Parent = this;
            HardcodedButton.Top = 50;
            HardcodedButton.Left = 50;
            HardcodedButton.Width = 500;
            HardcodedButton.Text = "HardcodedButton...";
            HardcodedButton.Click += new System.EventHandler(ExtendedButton);
        }

        private void SayHello(object sender, EventArgs args)
        {
            MessageBox.Show("Hello!");
        }

        private void ExtendedButton(object sender, EventArgs args)
        {
            HardcodedButton.Width += 10;
        }
    }
}