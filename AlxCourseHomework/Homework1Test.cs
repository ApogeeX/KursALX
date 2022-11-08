using AlxCourseHomework.MailingService;

namespace AlxCourseHomework
{
    public class Homework1Test
    {
        public static void Run()
        {
            var email1 = new Email("email.address1@gmail.com", "email.address1@yahoo.com", "Temat 1", "Treść wiadomości 1");
            var email2 = new Email("email.address2@gmail.com", "email.address2@yahoo.com", "Temat 2", "Treść wiadomości 2");
            var email3 = new Email("email.address3@gmail.com", "email.address3@yahoo.com", "Temat 3", "Treść wiadomości 3");
            var email4 = new Email("email.address4@gmail.com", "email.address4@yahoo.com", "Temat 4", "Treść wiadomości 4");
            var email5 = new Email("email.address5@gmail.com", "email.address5@yahoo.com", "Temat 5", "Treść wiadomości 5");

            EmailService.SendEmail(email1);
            EmailService.SendEmail(email2);
            EmailService.SendEmail(email3);
            EmailService.SendEmail(email4);
            EmailService.SendEmail(email5);
        }
    }
}
