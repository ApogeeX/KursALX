using ALXCalculator.Interfaces;

namespace ALXCalculator
{
    public class Calculator : ICalculator
    {
        List<char> ValidChars;
        char[] ValidOperatorArray = { '+', '-', '*', '/', '^' };

        public Calculator()
        {
            ValidChars = new List<char>();
            ValidChars.Add('+');
            ValidChars.Add('-');
            ValidChars.Add('*');
            ValidChars.Add('/');
            ValidChars.Add('^');
        }

        public void RunOnArray()
        {
            Console.WriteLine("Running caluculator...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Choose + - * / ^: ");
            var operationCharacterInfo = Console.ReadKey();

            while (ValidOperationOnArray(operationCharacterInfo.KeyChar))
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("First number: ");
                var x = Double.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                var y = Double.Parse(Console.ReadLine());
                PerformOperation(operationCharacterInfo.KeyChar, x, y);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Choose + - * / ^: ");
                operationCharacterInfo = Console.ReadKey();
            }
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("WRONG!!! Closing calculator");
        }

        /* public void RunOnList()
        {
            Console.WriteLine("Running caluculator...");
            Console.Write("Choose + - * / ^: ");
            var operationCharacterInfo = Console.ReadKey();

            while (ValidOperationOnList(operationCharacterInfo.KeyChar))
            {
                Console.WriteLine();
                Console.Write("First number: ");
                var x = Double.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                var y = Double.Parse(Console.ReadLine());
                PerformOperation(operationCharacterInfo.KeyChar, x, y);
                Console.WriteLine("");
                Console.Write("Choose + - * / ^: ");
                operationCharacterInfo = Console.ReadKey();
            }
            Console.WriteLine("");
            Console.WriteLine("WRONG!!! Closing calculator");
        } */

        private bool ValidOperationOnList(char operationCaracter)
        {
            return ValidChars.Contains(operationCaracter);
        }

        private bool ValidOperationOnArray(char operationCaracter)
        {
            return ValidOperatorArray.Contains(operationCaracter);
        }

        private void PerformOperation(char operationChar, double x, double y)
        {
            switch (operationChar)
            {
                case '+':
                    Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                    break;
                case '^':
                    Console.WriteLine($"{x}^{y} = {Power(x, y)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation...");
                    break;
            }
        }

        private double Add(double x, double y)
        {
            return x + y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }

        public double Divide(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public double Power(double x, double y)
        {
            return Math.Pow(x,y);
        }
    }
}
