
namespace HttpClientShowcase.Models
{
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string EmailTemplate { get; set; } = "cnestudio";
    }
}
