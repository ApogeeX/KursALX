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
                Console.Write("Enter chosen firearm: ");
                EnumFirearms chosenFirearm = (EnumFirearms)Enum.Parse(typeof(EnumFirearms), Console.ReadLine().ToUpper());
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
                    Console.WriteLine("Wrong fireamr, try again...");
                }

                if (addNewGun.ToString().ToLower() == "n")
                {
                    shootingList.PresentList();
                    Console.Write("Thank You for your visit.");
                }
                else
                {
                   // Console.Write("Thank You for your visit.");
                }
            }
        }
    }
}
