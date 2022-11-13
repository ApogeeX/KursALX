namespace KursALX.Assigments.M2.L2
{
    public class BookStorageService
    {
        List<Book> Syfy = new List<Book>();
        List<Book> Action = new List<Book>();
        List<Book> Fantasy = new List<Book>();
        List<Book> Kids = new List<Book>();
        List<Book> Cooking = new List<Book>();
        public static void AddToShelve(string title, string genre, string author, string isHardCover, string nuberOfPages)
        {

        }

        public static Book CreateBook()
        {
            var book = new Book();
            Console.Write("Please enter books title: ");
            book.Title = Console.ReadLine();
            Console.Write("Please enter books genre (syfy, action, fantsy, kids, cooking): ");
            book.Genre = (Genre)Int32.Parse(Console.ReadLine());
            Console.Write("Please enter books author: ");
            book.Author = Console.ReadLine();
            Console.Write("Please enter if book has hard cover (y/n): ");
            book.IsHardCover = Console.ReadLine();
            Console.Write("Please enter number of pages: ");
            book.NumberOfPages = Console.ReadLine();

            //book.PresentBook();
            return book;
        }

    }


}
