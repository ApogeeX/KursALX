using ShootingRange.Class;
using ShootingRange.Enums;

namespace ShootingRange
{
    public class ShootingList
    {
        List<string> UsedFirearms = new List<string>();
        List<uint> ShotsPerFirearm = new List<uint>();
        List<double> PricePerShot = new List<double>();

        public void AddGunToList(EnumFirearms chosenFirearm)
        {
            switch (chosenFirearm)
            {
                case EnumFirearms.AK47:
                    AK47 ak47 = new AK47();
                    if (ak47.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char singleOrAuto = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (singleOrAuto.ToString().ToLower() == "a")
                        {
                            Console.WriteLine($"Added {ak47.FirearmType.ToString()} in auto shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(ak47.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(ak47.AutoShotCost(numberOfShots), 2));
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Added {ak47.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(ak47.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(ak47.SingleShotCost(numberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Added {ak47.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                        UsedFirearms.Add(ak47.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(numberOfShots);
                        PricePerShot.Add(Math.Round(ak47.SingleShotCost(numberOfShots), 2));
                    }
                    break;
                case EnumFirearms.BERETTA:
                    Beretta beretta = new Beretta();
                    if (beretta.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char singleOrAuto = Console.ReadKey().KeyChar;
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (singleOrAuto.ToString().ToLower() == "a")
                        {
                            Console.WriteLine($"Added {beretta.FirearmType.ToString()} in auto shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(beretta.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(beretta.AutoShotCost(numberOfShots), 2));
                        }
                        else
                        {
                            Console.WriteLine($"Added {beretta.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(beretta.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(beretta.SingleShotCost(numberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Added {beretta.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                        UsedFirearms.Add(beretta.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(numberOfShots);
                        PricePerShot.Add(Math.Round(beretta.SingleShotCost(numberOfShots), 2));
                    }
                    break;
                case EnumFirearms.UZI:
                    UZI uzi = new UZI();
                    if (uzi.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char singleOrAuto = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (singleOrAuto.ToString().ToLower() == "a")
                        {
                            Console.WriteLine($"Added {uzi.FirearmType.ToString()} in auto shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(uzi.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(uzi.AutoShotCost(numberOfShots), 2));
                        }
                        else
                        {
                            Console.WriteLine($"Added {uzi.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(uzi.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(uzi.SingleShotCost(numberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Added {uzi.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                        UsedFirearms.Add(uzi.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(numberOfShots);
                        PricePerShot.Add(Math.Round(uzi.SingleShotCost(numberOfShots), 2));
                    }
                    break;
                case EnumFirearms.M4:
                    M4 m4 = new M4();
                    if (m4.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char singleOrAuto = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        if (singleOrAuto.ToString().ToLower() == "a")
                        {
                            Console.WriteLine($"Added {m4.FirearmType.ToString()} in auto shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(m4.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(m4.AutoShotCost(numberOfShots), 2));
                        }
                        else
                        {
                            Console.WriteLine($"Added {m4.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(m4.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(m4.SingleShotCost(numberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Added {m4.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                        UsedFirearms.Add(m4.FirearmType.ToString() + " in auto shot.");
                        ShotsPerFirearm.Add(numberOfShots);
                        PricePerShot.Add(Math.Round(m4.AutoShotCost(numberOfShots), 2));
                    }
                    break;
                case EnumFirearms.SCORPION:
                    Scorpion scorpion = new Scorpion();
                    if (scorpion.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char singleOrAuto = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.Write("Enter number of shots: ");
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        if (singleOrAuto.ToString().ToLower() == "a")
                        {
                            Console.WriteLine($"Added {scorpion.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(scorpion.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(scorpion.AutoShotCost(numberOfShots), 2));
                        }
                        else
                        {
                            Console.WriteLine($"Added {scorpion.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                            UsedFirearms.Add(scorpion.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(numberOfShots);
                            PricePerShot.Add(Math.Round(scorpion.SingleShotCost(numberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        Console.WriteLine();
                        uint numberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine($"Added {scorpion.FirearmType.ToString()} in single shot mode with {numberOfShots} shots.");
                        UsedFirearms.Add(scorpion.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(numberOfShots);
                        PricePerShot.Add(Math.Round(scorpion.SingleShotCost(numberOfShots), 2));
                    }
                    break;
            }
        }

        public void PresentList()
        {
            Console.Clear();
            Console.WriteLine("Guns on the shooting list:");
            for (int i = 0; i < UsedFirearms.Count; i++)
            {
                Console.WriteLine($"Firearm: {UsedFirearms[i]}\n\tNumber of shots: {ShotsPerFirearm[i]}\n\tPrice netto: {PricePerShot[i]}");
            }
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine($"Total cost netto: {TotalCostPerFirearm().ToString()}");
            Console.WriteLine($"To pay (VAT included): {Math.Round((TotalCostPerFirearm() * 1.23), 2).ToString()}");
        }

        public int TotalCostPerFirearm()
        {
            int total = 0;
            foreach (int i in PricePerShot)
            {
                total += i;
            }
            return total;
        }
    }
}
