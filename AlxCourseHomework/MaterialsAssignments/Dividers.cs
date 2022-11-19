namespace AlxCourseHomework.MaterialsAssignments
{
    public class Dividers
    {
        public static void Run()
        {
            int divider = 1;
            int dividedNumber;

            Console.Clear();
            Console.Write("Wprowadź proszę liczbę całkowitą: ");
            string enteredNumber = Console.ReadLine();
            if (Int32.TryParse(enteredNumber, out dividedNumber))
            {
                Console.Clear();
                Console.WriteLine($"Dzielna: {dividedNumber}");
                dividedNumber = Math.Abs(dividedNumber);
                if (dividedNumber == 0)
                {
                    Console.WriteLine("0 nie ma dzielników");
                }
                else if (dividedNumber == 1)
                {
                    Console.Write("Dzielniki: 1.");
                }
                else
                {
                    Console.Write("Dzielniki: ");
                    while (divider <= dividedNumber / 2)
                    {
                        if (dividedNumber % divider == 0)
                        {
                            Console.Write(divider + ", ");
                            divider++;
                        }
                        else
                        {
                            divider++;
                        }
                    }
                    Console.WriteLine($"{dividedNumber}.");
                }
            }
            else
            {
                Console.WriteLine("To nie jest liczba całkowita, program się zamknie.");
            }
        }
    }
}
