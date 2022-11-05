using AlxCourseHomework.MailingService;
using static System.Net.Mime.MediaTypeNames;

namespace AlxCourseHomework
{
    public class Homework1Test
    {
        public static void Run()
        {
            Email email1 = new Email("email.address1@gmail.com", "email.address1@yahoo.com", "Temat 1", "Treść wiadomości 1");
            Email email2 = new Email("email.address2@gmail.com", "email.address2@yahoo.com", "Temat 2", "Treść wiadomości 2");
            Email email3 = new Email("email.address3@gmail.com", "email.address3@yahoo.com", "Temat 3", "Treść wiadomości 3");
            Email email4 = new Email("email.address4@gmail.com", "email.address4@yahoo.com", "Temat 4", "Treść wiadomości 4");
            Email email5 = new Email("email.address5@gmail.com", "email.address5@yahoo.com", "Temat 5", "Treść wiadomości 5");

            EmailService.SendEmail(email1.FromAddress, email1.ToAddress, email1.Subject, email1.Message);
            EmailService.SendEmail(email2.FromAddress, email2.ToAddress, email2.Subject, email2.Message);
            EmailService.SendEmail(email3.FromAddress, email3.ToAddress, email3.Subject, email3.Message);
            EmailService.SendEmail(email4.FromAddress, email4.ToAddress, email4.Subject, email4.Message);
            EmailService.SendEmail(email5.FromAddress, email5.ToAddress, email5.Subject, email5.Message);
        }
    }
}
