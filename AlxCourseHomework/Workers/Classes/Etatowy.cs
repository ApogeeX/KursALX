using AlxCourseHomework.Workers.Classes.Enum;
using AlxCourseHomework.Workers.Interfaces;

namespace AlxCourseHomework.Workers.Classes
{
    public class Etatowy : Worker, IContracts
    {
        public Etatowy (string name, string surname, uint overtime = 0) : base()
        {
            MonthlyRate = 5000;
            Overtime = overtime;
            Name = name;
            Surname = surname;
            Contract = EnumContracts.ETATOWY;
        }

        public double CalculatePay()
        {
            if (Contract == EnumContracts.ETATOWY)
            {
                return Pay = Math.Round(MonthlyRate + (Overtime * MonthlyRate / 60), 2);
            }
            else
            {
                return Pay = Math.Round(MonthlyRate, 2);
            }
        }
    }
}
