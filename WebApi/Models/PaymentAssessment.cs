using System.Security.Principal;

namespace WebApi.Models
{
    public class PaymentAssessment
    {
        public string PaycheckNumber { get; set; }
        public decimal PaymentGross { get; set; }
    }
}