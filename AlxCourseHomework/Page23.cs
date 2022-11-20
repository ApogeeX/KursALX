using System;

namespace AlxCourseHomework
{
    public class Page23
    {
        public static void ArraySearch()
        {
            string[] products = new string[4] { "CHLEB", "MASŁO", "KETCHUP", "SOK" };
            double[] bruttoPrices = new double[4] { 3.75, 6.99, 5.50, 3.75 };
            int isOk = 1;

            do
            {
                isOk = 1;
                Console.Clear();
                Console.WriteLine("Products array: ");
                foreach (string item in products)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                Console.WriteLine("Pick item: ");
                string chosenProduct = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Console.WriteLine($"Price of {chosenProduct}: ");
                try
                {
                    Console.WriteLine($"Brutto: {bruttoPrices[Array.IndexOf(products, chosenProduct)]} \nNetto: {Math.Round(bruttoPrices[Array.IndexOf(products, chosenProduct)] / 1.23, 2)}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine($"There is no such item in the database");
                    Console.WriteLine($"Press any key to try again");
                    Console.ReadKey();
                    isOk = 0;
                }
            } while (isOk == 0);
            Console.WriteLine($"Press any key to close the program.");
            Console.ReadKey();
        }

        public static void Run()
        {

        }
    }
}
