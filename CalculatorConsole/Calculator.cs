
using CommonFunctionalities.Interfaces;
using CommonFunctionalities.Services;

namespace CalculatorConsole
{
    public class Calculator
    {
        private IExpressionService Service;

        public Calculator()
        {
            Service = new ExpressionServiceDecimal();
        }
        public void Run()
        {
            Console.Write("Enter an expression: ");
            var expression = Console.ReadLine();
            expression = RefactorExpression(expression);
            var result = Service.ProcessExpression(expression);
            Console.WriteLine($"Result: {result}");
        }

        private string RefactorExpression(string expression)
        {
            expression = expression.Trim();
            expression = expression.Replace(" ", String.Empty);
            return expression;
        }
    }
}
