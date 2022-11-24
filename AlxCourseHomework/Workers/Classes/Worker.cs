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
            Contract = EnumContracts.STAŻ;
        }

        public void ChangeContract()
        {
            if (Contract == EnumContracts.STAŻ)
            {
                Contract = EnumContracts.ETAT;
                MonthlyRate = 5000;
                Overtime = 0;
                Console.WriteLine($"Contract changed to ETAT. Monthly rate set to {MonthlyRate} and overtime set to {Overtime}.");
            }
        }

      public double CalculatePay()
        {
            if (Contract == EnumContracts.ETAT)
            {
                return Pay = Math.Round(MonthlyRate + (Overtime * MonthlyRate / 60), 2);
            }
            else
            {
                return Pay = Math.Round(MonthlyRate, 2);
            }
        }

        public string Present()
        {
            return Name + " " + Surname + " Pay: " + Pay.ToString();
        }
    }
}
