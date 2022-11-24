namespace AlxCourseHomework.Workers.Classes
{
    public class Staz : Contracts
    {
        public Staz(string contractName = "Staz", double monthlyPay = 1000) : base(contractName, monthlyPay)
        {
        }
        public double CalculatePay()
        {
            return MonthlyPay;
        }
    }
}

