namespace InvoicesApp.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public string SeriesNumber { get; set; }
        public string ClientCompanyName { get; set; }
        public string ClientNIP { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public double Amount { get; set; }
    }
}
