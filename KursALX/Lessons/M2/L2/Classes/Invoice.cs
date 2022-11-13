using System.Runtime.InteropServices;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class Invoice
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int NIP { get; set; }
        public double BruttoAmount { get; set; }
        public double NettoAmmount { get; set; }
    
        public void PresentInvioce()
        {
            Console.WriteLine($"[Invoice] Id {Id}");
            Console.WriteLine($"\tCustomer name: {CustomerName}");
            Console.WriteLine($"\tNIP: {NIP}");
            Console.WriteLine($"\tIncome (brutto): {BruttoAmount}");
            Console.WriteLine($"\tIncome (netto): {NettoAmmount}");
        }
    }
}
