using AlxCourseHomework.Workers.Classes;

namespace AlxCourseHomework.Workers
{
    public class WorkerService
    {
        public static void Run()
        {
            var worker1 = new Etatowy ("Emil", "Pałczyński");

            var worker2 = new Stazysta ("Szymon", "Pałczyński");

            worker1.CalculatePay();
            Console.WriteLine(worker1.Present());
            Console.WriteLine();
            worker2.CalculatePay();
            Console.WriteLine(worker2.Present());
            Console.WriteLine();
            worker2.ChangeContract();
            worker2.ChangeOvertime(5);
            worker2.CalculatePay();
            Console.WriteLine(worker2.Present());
        }
    }
}
