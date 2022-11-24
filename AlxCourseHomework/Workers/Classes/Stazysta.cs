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
    }
}
