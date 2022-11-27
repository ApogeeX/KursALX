using CommonFunctionalities.Interfaces;
using System.Text;

namespace CommonFunctionalities.Services
{
    public class ExpressionServiceDecimal : IExpressionService
    {
        public string ProcessExpression(string expression)
        {
            if (!expression.EndsWith("="))
            {
                expression += "=";
            }
            var result = CreateNumberSubstring(expression);
            return result.ToString();
        }

        private decimal CreateNumberSubstring(string expression)
        {
            List<decimal> numbers = new List<decimal>();
            List<char> operations = new List<char>();
            var numberBuilder = new StringBuilder();
            //expression = expression.Replace(',', '.');
            var expressionArray = expression.ToCharArray();

            for (int i = 0; i < expressionArray.Length; i++)
            {
                if (Char.IsDigit(expressionArray[i]) || expressionArray[i] == ',')
                {
                    numberBuilder.Append(expressionArray[i]);
                }
                else
                {
                    var number = Convert.ToDecimal(numberBuilder.ToString());
                    numberBuilder.Clear();
                    numbers.Add(number);
                    operations.Add(expressionArray[i]);
                }
            }
            var result = PerformOperations(numbers, operations);
            return result;
        }

        private decimal PerformOperations(List<decimal> numbers, List<char> operations)
        {
            var result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }

            return result;
        }

        private decimal PerformOperation(char operationChar, decimal x, decimal y)
        {
            switch (operationChar)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/':
                    return x / y;
                default:
                    return x;
            }
        }
    }
}