namespace AlxCourseHomework.MaterialsAssignments
{
    public class SetDiscount
    {
        public int Discount;

        public SetDiscount(int discount)
        {
            Discount = discount;
        }

        public static int IfSet(int basketIf)
        {
            int discount = 0;
            if (basketIf > 99)
            {
                discount = 15;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Discount set to: {discount}%.");
                Console.ResetColor();
            }
            else if (basketIf < 61)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"No discount set.");
                Console.ResetColor();
            }
            else
            {
                discount = 5;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Discount set to {discount}%.");
                Console.ResetColor();
            }
            return discount;
        }
        public static int SwitchSet(int basketSwitch)
        {
            int discount = 0;
            switch (basketSwitch)
            {
                case > 99:
                    discount = 15;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Discount set to: {discount}%.");
                    Console.ResetColor();
                    break;
                case < 61:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"No discount set.");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    discount = 5;
                    Console.WriteLine($"Discount set to {discount}%.");
                    break;
            }
            return discount;
        }
    }
}
