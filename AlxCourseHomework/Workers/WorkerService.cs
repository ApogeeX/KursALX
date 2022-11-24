using AlxCourseHomework.Workers.Classes;

namespace AlxCourseHomework.Workers
{
    public class WorkerService
    {
        public static void Run()
        {
            var worker1 = new Etat("Emil", "Pałczyński");

            var worker2 = new Staz("Szymon", "Pałczyński");

            worker1.CalculatePay();
            Console.WriteLine(worker1.Present());
            Console.WriteLine();
            worker2.CalculatePay();
            Console.WriteLine(worker2.Present());
            Console.WriteLine();
            worker2.ChangeContract();
            worker2.Overtime = 5;
            Console.WriteLine($"Overtime set to {worker2.Overtime}.");
            worker2.CalculatePay();
            Console.WriteLine(worker2.Present());
        }
    }
}
