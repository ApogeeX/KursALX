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
    }
}
