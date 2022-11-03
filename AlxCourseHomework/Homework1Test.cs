using AlxCourseHomework.MailingService;
using static System.Net.Mime.MediaTypeNames;

namespace AlxCourseHomework
{
    public class Homework1Test
    {
        public static void Run()
        {
            Email email1 = new Email();
            email1.FromAddress = "emil.palczynski@gmail.com";
            email1.ToAddress = "epalczynski@awas-serwis.pl";
            email1.Subject = "Test 1";
            email1.Message = "Treść wiadomości 1";
            var email2 = new Email("emil.palczynski@gmail.com", "epalczynski@awas-serwis.pl", "Test 2", "Treść wiadomości 2");
            Email email3 = new Email("emil.palczynski@gmail.com", "epalczynski@awas-serwis.pl", "Test 3", "Treść wiadomości 3");
            Email email4 = new Email("emil.palczynski@gmail.com", "epalczynski@awas-serwis.pl", "Test 4", "Treść wiadomości 4");
            Email email5 = new Email("emil.palczynski@gmail.com", "epalczynski@awas-serwis.pl", "Test 5", "Treść wiadomości 5");

            EmailService.SendEmail(email1.FromAddress, email1.ToAddress, email1.Subject, email1.Message);
            EmailService.SendEmail(email2.FromAddress, email2.ToAddress, email2.Subject, email2.Message);
            EmailService.SendEmail(email3.FromAddress, email3.ToAddress, email3.Subject, email3.Message);
            EmailService.SendEmail(email4.FromAddress, email4.ToAddress, email4.Subject, email4.Message);
            EmailService.SendEmail(email5.FromAddress, email5.ToAddress, email5.Subject, email5.Message);
        }
    }
}
