namespace KursALX.Lessons.M1.L2
{
    public class L2Conditionals
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            var number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter down limit: ");
            var limit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter upper limit: ");
            var limit2 = Int32.Parse(Console.ReadLine());

            ChcekIfWhithin(number, limit1, limit2);
            CheckIfNumberIsEven(number);
        }

        private static void ChcekIfWhithin(int number, int limit1, int limit2)
        {
            if (number < limit1)
            {
                Console.WriteLine($"Number is smaller then {limit1}.");
            }
            else if (number > limit2)
            {
                Console.WriteLine($"Number is greater then {limit2}.");
            }
            else
            {
                Console.WriteLine($"Number is between {limit1} and {limit2} or is equal to {limit1} or {limit2}.");
            }
        }
        private static void CheckIfNumberIsEven(int number)
        {    
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is an odd number.");
            }
        }
    }
}
