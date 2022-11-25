using AlxCourseHomework.Workers.Classes.Enum;
using AlxCourseHomework.Workers.Interfaces;

namespace AlxCourseHomework.Workers.Classes
{
    public class Stazysta : Worker , IContracts
    {
        public Stazysta(string name, string surname) : base()
        {
            MonthlyRate = 1000;
            Name = name;
            Surname = surname;
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
