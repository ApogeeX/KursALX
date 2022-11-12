namespace KursALX.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Mateusz");
            names.Add("Monika");
            names.Add("Magda");
            names.Add("Andrzej");
            
            foreach(string name in names)
            {
                Console.WriteLine(name.ToLower() + " kursant.");
                Console.WriteLine(name);
            }
        }

        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 66, 77 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = numbers[i] % 2;
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public static void RunWhile()
        {
            Console.WriteLine("Write a character: ");
            var c = Console.ReadKey().KeyChar;
            while (c != 'n')
            {
                Console.WriteLine("Still in the loop!");
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Outsite the loop");

            string numberFromKeyboard = "0";
            while (Int32.Parse(numberFromKeyboard) < 100000)
            {
                Console.WriteLine("Still in the loop!");
                Console.WriteLine("Write a number: ");
                numberFromKeyboard = Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Outsite the loop");
        }

        public static void RunDowhile()
        {
            Console.WriteLine("Write a character: ");
            var c = Console.ReadKey().KeyChar;

            do
            {
                Console.WriteLine("Still in the loop!");
                Console.WriteLine("Write a character: ");
                c = Console.ReadKey().KeyChar;
            } while (c != 'n');
            Console.WriteLine("");
            Console.WriteLine("Outsite the loop");
        }

        public static void RunWhile2()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 66, 77 };

            int iterator = 0;

            while(iterator < numbers.Length)
            {
                Console.Write(numbers[iterator] + " ");
                iterator++;
            }
            Console.WriteLine();
        }
    }
}
