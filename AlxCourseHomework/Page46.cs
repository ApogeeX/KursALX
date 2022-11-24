using AlxCourseHomework.Workers.Classes;

namespace AlxCourseHomework
{
    public class Page46
    {
        public static void Run()
        {
            Worker worker1 = new Worker();
            Console.Write("Enter workers name: ");
            worker1.Name = Console.ReadLine();
            Console.Write("Enter workers surname: ");
            worker1.Surname = Console.ReadLine();
            Console.WriteLine("Workers contract set to 'Staż'.");
            worker1.Contract = "Staż";
            Console.Write("Change to Etat? (y/n): ");
            char yesNo = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (yesNo.ToString().ToLower())
            {
                case "y":
                    worker1.ChangeContract("Etat");
                    break;
                case "n":
                    break;
                default:
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine(worker1.Present());
            Worker worker2 = new Worker("Szymon", "Pałczyński");
            Console.WriteLine();
            Console.WriteLine(worker2.Present());
        }
    }
}
