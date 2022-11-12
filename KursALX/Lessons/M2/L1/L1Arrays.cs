using System.Security.Cryptography.X509Certificates;
using KursALX.Lessons.M1.L1.Classes;

namespace KursALX.Lessons.M2.L1
{
    public class L1Arrays
    {
        public static void Run()
        {
            int[] indexArray1 = { 0, 1, 2, 3, 4 };
            int[] intArray1 = new int[5];
            ShowArray(indexArray1);

            intArray1[2] = 2;
            ShowArray(intArray1);

            int[] intArray2 = new int[3] { 1, 2, 3 };
            ShowArray(intArray2);

            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };

            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog();
        }

        public static void Run1()
        {
            Console.WriteLine("Arrays");
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";
            ShowArray(shoppingArray);
            shoppingArray[1] = "sugar";
            ShowArray(shoppingArray);
            shoppingArray[2] = "coffe";
            ShowArray(shoppingArray);
            shoppingArray[3] = "papaya";
            ShowArray(shoppingArray);
        }
        public static void Run2()
        {
            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };
            int[,] intMatrix2 = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
            
            Show2DArray(intMatrix2);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        public static void Show2DArray(int[,] matrix)
        {
            for (int iterator = 0; iterator< matrix.GetLength(0); iterator++)
            {
                for (int iterator1 = 0; iterator1 < matrix.GetLength(1); iterator1++)
                {
                    //var number = matrix[iterator, interator1];
                    //Console.WriteLine(number);
                    Console.Write($"{matrix[iterator, iterator1]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
