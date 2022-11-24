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
    }
}
