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
                    Console.WriteLine("Adding " + ak47.FirearmType.ToString() + " to the list.");
                    if (ak47.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char SingleOrAuto = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (SingleOrAuto.ToString().ToLower() == "a")
                        {
                            UsedFirearms.Add(ak47.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(ak47.AutoShotCost(NumberOfShots), 2));
                        }
                        else
                        {
                            UsedFirearms.Add(ak47.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(ak47.SingleShotCost(NumberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        UsedFirearms.Add(ak47.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(NumberOfShots);
                        PricePerShot.Add(Math.Round(ak47.SingleShotCost(NumberOfShots), 2));
                    }
                    break;
                case EnumFirearms.BERETTA:
                    Beretta beretta = new Beretta();
                    Console.WriteLine("Adding " + beretta.FirearmType.ToString() + " to the list.");
                    if (beretta.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char SingleOrAuto = Console.ReadKey().KeyChar;
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        if (SingleOrAuto.ToString().ToLower() == "a")
                        {
                            UsedFirearms.Add(beretta.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(beretta.AutoShotCost(NumberOfShots), 2));
                        }
                        else
                        {
                            UsedFirearms.Add(beretta.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(beretta.SingleShotCost(NumberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        UsedFirearms.Add(beretta.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(NumberOfShots);
                        PricePerShot.Add(Math.Round(beretta.SingleShotCost(NumberOfShots), 2));
                    }
                    break;
                case EnumFirearms.UZI:
                    UZI uzi = new UZI();
                    Console.WriteLine("Adding " + uzi.FirearmType.ToString() + " to the list.");
                    if (uzi.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char SingleOrAuto = Console.ReadKey().KeyChar;
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        if (SingleOrAuto.ToString().ToLower() == "a")
                        {
                            UsedFirearms.Add(uzi.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(uzi.AutoShotCost(NumberOfShots), 2));
                        }
                        else
                        {
                            UsedFirearms.Add(uzi.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(uzi.SingleShotCost(NumberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        UsedFirearms.Add(uzi.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(NumberOfShots);
                        PricePerShot.Add(Math.Round(uzi.SingleShotCost(NumberOfShots), 2));
                    }
                    break;
                case EnumFirearms.M4:
                    M4 m4 = new M4();
                    Console.WriteLine("Adding " + m4.FirearmType.ToString() + " to the list.");
                    if (m4.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char SingleOrAuto = Console.ReadKey().KeyChar;
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        if (SingleOrAuto.ToString().ToLower() == "a")
                        {
                            UsedFirearms.Add(m4.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(m4.AutoShotCost(NumberOfShots), 2));
                        }
                        else
                        {
                            UsedFirearms.Add(m4.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(m4.SingleShotCost(NumberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        UsedFirearms.Add(m4.FirearmType.ToString() + " in auto shot.");
                        ShotsPerFirearm.Add(NumberOfShots);
                        PricePerShot.Add(Math.Round(m4.AutoShotCost(NumberOfShots), 2));
                    }
                    break;
                case EnumFirearms.SCORPION:
                    Scorpion scorpion = new Scorpion();
                    Console.WriteLine("Adding " + scorpion.FirearmType.ToString() + " to the list.");
                    if (scorpion.HasAuto == true)
                    {
                        Console.Write("Single shot or auto shot (S/A): ");
                        char SingleOrAuto = Console.ReadKey().KeyChar;
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        if (SingleOrAuto.ToString().ToLower() == "a")
                        {
                            UsedFirearms.Add(scorpion.FirearmType.ToString() + " in auto shot.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(scorpion.AutoShotCost(NumberOfShots), 2));
                        }
                        else
                        {
                            UsedFirearms.Add(scorpion.FirearmType.ToString() + " in single shot mode.");
                            ShotsPerFirearm.Add(NumberOfShots);
                            PricePerShot.Add(Math.Round(scorpion.SingleShotCost(NumberOfShots), 2));
                        }
                    }
                    else
                    {
                        Console.WriteLine("This firearm has only single shot mode.");
                        Console.Write("Enter number of shots: ");
                        uint NumberOfShots = uint.Parse(Console.ReadLine());
                        UsedFirearms.Add(scorpion.FirearmType.ToString() + " in single shot mode.");
                        ShotsPerFirearm.Add(NumberOfShots);
                        PricePerShot.Add(Math.Round(scorpion.SingleShotCost(NumberOfShots), 2));
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
