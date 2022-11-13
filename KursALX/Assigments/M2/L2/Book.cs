using System.Security.Cryptography.X509Certificates;

namespace KursALX.Assigments.M2.L2
{
    public class Book
    {
        public string Title;
        public Genre Genre;
        public string Author;
        public string IsHardCover;
        public string NumberOfPages;
        
        public void PresentBook()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Book has hard cover?: {IsHardCover}");
            Console.WriteLine($"Book has: {NumberOfPages} pages.");
        }
    }
}
