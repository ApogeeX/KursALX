using CommonFunctionalities.Services;
using CommonFunctionalities.Interfaces;
using System.Text;


namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {
        private StringBuilder ExpressionBuilder { get; set; }
        private IExpressionService ExpressionService { get; set; }
        public CalculatorForm()
        {
            ExpressionService = new ExpressionServiceDecimal();
            ExpressionBuilder = new StringBuilder();
            ExpressionBuilder.Clear();
            InitializeComponent();
        }

        private void expressionBuilderButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("Hello ");
            ExpressionBuilder.Append("user ");
            ExpressionBuilder.Append("this ");
            ExpressionBuilder.Append("is ");
            ExpressionBuilder.Append("a ");
            ExpressionBuilder.Append("string builder. ");
            resultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Clear();
        }

        private void ExpressionButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendExpression(button.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            resultTextBox.Text = ExpressionBuilder.ToString();
            resultTextBox.Font = new Font(resultTextBox.Font.FontFamily, 24f);
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendExpression(button.Text);
            var expression = resultTextBox.Text;
            var result = ExpressionService.ProcessExpression(expression);
            resultTextBox.Text = result.ToString();
            ExpressionBuilder.Clear();
        }

        private void AppendExpression(string expressionPart)
        {
            ExpressionBuilder.Append(expressionPart);
            resultTextBox.Text = ExpressionBuilder.ToString();

            var textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), resultTextBox.Font);
            while (textLenght.Width > resultTextBox.Width)
            {
                resultTextBox.Font = new Font(resultTextBox.Font.FontFamily, resultTextBox.Font.Size - 1f);
                textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), resultTextBox.Font);
            }
        }
    }
}