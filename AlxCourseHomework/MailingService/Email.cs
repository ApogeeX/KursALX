namespace AlxCourseHomework.MailingService
{
    public class Email
    {
        public string FromAddress;
        public string ToAddress;
        public string Subject;
        public string Message;
                
        public Email(string fromAddress, string toAddress, string subject, string message)
        {
            FromAddress = fromAddress;
            ToAddress = toAddress;
            Subject = subject;
            Message = message;
        }

    }
}
