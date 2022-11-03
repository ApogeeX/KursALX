namespace AlxCourseHomework.MailingService
{
    public static class EmailService
    {
        public static void SendEmail(string fromAddress, string toAddress, string subject, string message)
        {
            Console.WriteLine("Email has been sent...");
            Console.WriteLine($"From: {fromAddress}");
            Console.WriteLine($"To: {toAddress}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
