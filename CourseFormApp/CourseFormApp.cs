using Microsoft.VisualBasic;
using System.Diagnostics;

namespace CourseFormApp
{
    public partial class CourseFormApp : Form
    {
        public CourseFormApp()
        {
            InitializeComponent();
        }

        private void DoNotClickButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are a rebel!");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShutdownPC_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0 /f");
        }

        private void HeigtButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your height is {HeightTextBox1.Text} cm!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
               var result = PerformOpertaion(Convert.ToDouble(XNumberTextBox.Text),
                                            Convert.ToDouble(YNumberTextBox.Text));
                ResultTextBox.Text = result.ToString();
                LogTextBox.Text += "Operation performed successfully!" + "\n";
            }
            catch (Exception ex)
            {
                var exeptionMessage = "Exeption cought!";
                LogTextBox.Text = exeptionMessage;
                ResultTextBox.Text += "Invalid operation!";
            }
            finally
            {
                LogTextBox.Text += "Operation Performed...";
            }
        }

        private double PerformOpertaion(double x, double y)
        {
            if (AddButton.Checked)
                return x + y;
            else if (SubstractButton.Checked)
                return x - y;
            else if (MultiplyButton.Checked)
                return x * y;
            else
                return x / y;
        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }
    }
}