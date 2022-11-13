using ALXCalculator;
using ALXCalculator.Interfaces;

Console.WriteLine("-- ALX CALCULATOR --");

ICalculator calculator = new Calculator();
//calculator.RunOnList();
calculator.RunOnArray();
Console.WriteLine("--------------------");
