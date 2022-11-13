namespace KursALX.Assigments.M2.L2
{
    public class Book
    {
        public string Title;
        public Genre Genre;
        public string Author;
        public string Description;
        public int NumberOfPages;

        public Book()
        {
        }
        public Book(string title, Genre genre, string author, string description, int numberOfPages)
        {
            Title = title;
            Genre = genre;
            Author = author;
            Description = description;
            NumberOfPages = numberOfPages;
        }

        public void PresentBook()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Book has hard cover?: {Description}");
            Console.WriteLine($"Book has: {NumberOfPages} pages.");
        }
    }
}
