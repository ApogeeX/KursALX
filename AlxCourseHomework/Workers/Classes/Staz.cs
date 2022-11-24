using AlxCourseHomework.Workers.Interfaces;

namespace AlxCourseHomework.Workers.Classes
{
    public class Staz : Worker , IContracts
    {
        public Staz(string name, string surname) : base()
        {
            MonthlyRate = 1000;
            Name = name;
            Surname = surname;
        }
        //public void ShowWorker()
        //{
        //    Console.WriteLine($"Worker name: {Name}");
        //    Console.WriteLine($"Worek contract: {Contract}"); ;
        //    Console.WriteLine($"Salary: {Math.Round(Salary, 2)}");
        //}
        //public double CalculatePay()
        //{
        //    return Pay = Math.Round(MonthlyRate, 2);
        //}
    }
}
