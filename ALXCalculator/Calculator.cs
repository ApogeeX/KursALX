using System;

namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Running caluculator...");
            Console.Write("X number: ");
            var x = Double.Parse(Console.ReadLine());
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine());
            Console.Write("Choose + - * /: ");
            var operationCharacterInfo = Console.ReadKey();
            Console.Write();

            PerformOperation(operationCharacterInfo.KeyChar,x,y);
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
            return x / y;
        }
    }
}
