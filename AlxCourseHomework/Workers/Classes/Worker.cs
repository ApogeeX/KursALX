using AlxCourseHomework.Workers.Classes.Enum;

namespace AlxCourseHomework.Workers.Classes
{
    public abstract class Worker
    {
        public string Name;
        public string Surname;
        public EnumContracts Contract;
        public double Pay;
        public double MonthlyRate;
        public uint Overtime;

        public Worker()
        {
            Contract = EnumContracts.STAŻYSTA;
        }

        public void ChangeContract()
        {
            if (Contract == EnumContracts.STAŻYSTA)
            {
                Contract = EnumContracts.ETATOWY;
                MonthlyRate = 5000;
                Overtime = 0;
                Console.WriteLine($"Contract changed to ETATOWY. Monthly rate set to {MonthlyRate} and overtime set to {Overtime}.");
            }
        }

        public void ChangeOvertime(uint overtime)
        {
            Overtime = overtime;
            Console.WriteLine("Overtime changed to: " + overtime);
        }

        public string Present()
        {
            return Name + " " + Surname + ", Contract: " + Contract + ", Pay: " + Pay.ToString();
        }
    }
}
