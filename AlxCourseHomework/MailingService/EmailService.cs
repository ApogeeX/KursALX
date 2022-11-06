namespace AlxCourseHomework.MailingService
{
    public static class EmailService
    {
        public static void SendEmail(Email email)
        {
            var fromAddress = email.FromAddress;
            var toAddress = email.ToAddress;
            var subject = email.Subject;
            var message = email.Message;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Email has been sent...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"From: {fromAddress}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"To: {toAddress}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Subject: {subject}");
            Console.ResetColor();
            Console.WriteLine($"Message: {message}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
        }
    }
}
