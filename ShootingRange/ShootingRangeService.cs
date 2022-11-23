using ShootingRange.Class;
using ShootingRange.Enums;

namespace ShootingRange
{
    public class ShootingRangeService
    {
        public static void Run()
        {
            List<string> ListOfUsedFirearms = new List<string>();
            List<uint> ShotsPerFirearm = new List<uint>();
            List<double> PricePerFirearmShot = new List<double>();

            Console.WriteLine("Welcome, this is our gun choice:");
            Console.WriteLine();
            foreach (var firearm in Enum.GetValues(typeof(EnumFirearms)))
            {
                Console.WriteLine(firearm);
            }
            Console.Write("Want to create new shooting order? (Y/N) ");
            var addNextGun = Console.ReadKey().KeyChar;


            while (addNextGun.ToString().ToLower() == "y")
            {
                Console.Write("Choose Firearms to shoot: ");
                EnumFirearms chosenFirearm = (EnumFirearms)Enum.Parse(typeof(EnumFirearms), Console.ReadLine().ToUpper());
                if (Enum.IsDefined(typeof(EnumFirearms), chosenFirearm))
                {
                    AddShootingWithChosenFirearm(chosenFirearm);
                    Console.WriteLine("Do you wish to add more shoots? (Y/N)");
                    addNextGun = Console.ReadKey().KeyChar;
                }
                else
                {
                    Console.WriteLine("Wrong firearm. Try again");
                }
            }
            if (addNextGun.ToString().ToLower() == "n")
            {
                ShowRecipt();
            }

            void AddShootingWithChosenFirearm(EnumFirearms choosingFirearm)
            {
                Firearms newFirearm = new Firearms(choosingFirearm);
                Console.WriteLine("You chose: " + newFirearm.FirearmType.ToString());
                ListOfUsedFirearms.Add(newFirearm.FirearmType.ToString());
                Console.Write("Full auto or single action (S/A)? ");
                var shootingTypeChoice = Console.ReadKey().KeyChar;
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShots = uint.Parse(Console.ReadLine());
                ShotsPerFirearm.Add(chosenNumberOfShots);
                switch (shootingTypeChoice)
                {
                    case 'S':
                        PricePerFirearmShot.Add(Math.Round(newFirearm.ShootingSingleCost(chosenNumberOfShots), 2));
                        break;
                    case 'F':
                        PricePerFirearmShot.Add(Math.Round(newFirearm.ShootingAutoCost(chosenNumberOfShots), 2));
                        break;
                }
            }
            void ShowRecipt()
            {
                Console.WriteLine("List of shots");
                for (int i = 0; i < ListOfUsedFirearms.Count; i++)
                {
                    Console.WriteLine($"Gun: {ListOfUsedFirearms[i]} Number of Shots: {ShotsPerFirearm[i]} Price netto: {PricePerFirearmShot[i]}");
                }
                Console.WriteLine("Summary netto:       \t" + SummingCost().ToString());
                Console.WriteLine("TAX 23%:             \t" + Math.Round(SummingCost() * 0.23, 2).ToString());
                Console.WriteLine("To pay (VAT included)\t" + Math.Round(SummingCost() * 1.23, 2).ToString());
            }
            int SummingCost()
            {
                int sum = 0;
                foreach (int i in PricePerFirearmShot)
                {
                    sum += i;
                }
                return sum;
            }
        }
    }
}
