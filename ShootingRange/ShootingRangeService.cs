using ShootingRange.Enums;
using System.ComponentModel;

namespace ShootingRange
{
    public class ShootingRangeService
    {
        public static void Run()
        {
            var shootingList = new ShootingList();
            Console.WriteLine("Firearms list:");
            foreach (var firearmType in Enum.GetValues(typeof(EnumFirearms)))
            {
                Console.WriteLine(firearmType);
            }
            char addNewGun = 'y';
            Console.WriteLine();
            while (addNewGun.ToString().ToLower() == "y")
            {
                Console.Write("Enter firearm to add to the list: ");
                EnumFirearms chosenFirearm;
                try
                {
                    chosenFirearm = (EnumFirearms)Enum.Parse(typeof(EnumFirearms), Console.ReadLine().ToUpper());
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong firearm, try again...");
                    Console.WriteLine("Closing app.");
                    break;
                }
                Console.WriteLine();
                if (Enum.IsDefined(typeof(EnumFirearms), chosenFirearm))
                {
                    shootingList.AddGunToList(chosenFirearm);
                    Console.Write("Press Y to add another firearm, or N to show shooting list: ");
                    addNewGun = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Not firearm, try again.");
                }

                if (addNewGun.ToString().ToLower() == "n")
                {
                    shootingList.PresentList();
                    Console.Write("Thank You for your visit.");
                }
            }
        }
    }
}
