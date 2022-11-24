namespace AlxCourseHomework.Workers.Classes
{
    public class Etat : Contracts
    {
        public uint Overtime { get; set; }
        
        public Etat (string contractName = "Etat", double monthlyPay = 5000, uint overtime = 0) : base (contractName, monthlyPay)
        {
            Overtime = overtime;
        }

        public double CalculatePay()
        {
            return MonthlyPay + (Overtime * MonthlyPay / 60);
        }

     }
}
