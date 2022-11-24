namespace AlxCourseHomework.Workers.Classes
{
    public class Contracts
    {
        public string ContractName { get; set; }
        public double MonthlyPay { get; set; }

        public Contracts(string contractName, double monthlyPay)
        {
            ContractName = contractName;
            MonthlyPay = monthlyPay;
        }   
    }
}
