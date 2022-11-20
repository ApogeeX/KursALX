using System.Globalization;

namespace AlxCourseHomework
{
    public class Page23
    {
        public static void ArraySearch()
        {
            string[] products = new string[7] { "CHLEB", "MASŁO", "KETCHUP", "SOK", "JAJKA", "SZPINAK", "LODY" };
            double[] bruttoPrices = new double[7] { 15.23, 64.00, 45.50, 105.55, 14.23, 1421.89, 7899.99 };
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

        public static void Array3On3()
        {
            int[,] ints = new int[3,3];
            int number = 1;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    ints[x,y] = number++;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine($"{ints[x, 0]} {ints[x, 1]} {ints[x, 2]}");     
            }
        }

        public static void ArrayChange()
        {
            int[] numbersToChange = new int[5];
            for (int x = 0; x < 5; x++)
            {
                Console.Write($"Please enter number {x+1} of 5: ");
                try
                {
                    numbersToChange[x] = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("That was not a valid number, zero entered as default.");
                    numbersToChange[x] = 0;
                }
                Console.WriteLine();
            }

            for(int x = 0; x < 5; x++)
            {
                numbersToChange[x] = numbersToChange[x] * 2;
            }

            Console.Write("Array after '*2': ");
            foreach (int i in numbersToChange)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
