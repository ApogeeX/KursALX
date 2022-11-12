namespace KursALX.Assigments.Classes
{
    public class Book
    {
        public string Title;
        public bool HardCover;
        public int Pages;
        public string Author;
       
        public void OpenBook()
        {
            Console.WriteLine("Book opened on random page...");
            Console.WriteLine($" ");
        }

        public void Present()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Hard cover: {HardCover}");
            Console.WriteLine($"Number of pages: {Pages}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($" ");
        }
    }
}
