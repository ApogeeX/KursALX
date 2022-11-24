using AlxCourseHomework.Workers.Classes.Enum;
using AlxCourseHomework.Workers.Interfaces;

namespace AlxCourseHomework.Workers.Classes
{
    public class Etat : Worker, IContracts
    {
        public Etat(string name, string surname, uint overtime = 0) : base()
        {
            MonthlyRate = 5000;
            Overtime = overtime;
            Name = name;
            Surname = surname;
            Contract = EnumContracts.ETAT;
        }
        //public double CalculatePay()
        //{
        //    return Pay = Math.Round(MonthlyRate + (Overtime * MonthlyRate / 60), 2);
        //}
    }
}
