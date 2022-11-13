using System.Reflection;

namespace KursALX.Assigments.M2.L2
{
    public class BookStorageService
    {
        List<Book> Syfy;
        List<Book> Action;
        List<Book> Fantasy;
        List<Book> Kids;
        List<Book> Cooking;

        public BookStorageService()
        {
            Syfy = new List<Book>();
            Action = new List<Book>();
            Fantasy = new List<Book>();
            Kids = new List<Book>();
            Cooking = new List<Book>();
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("SciFi Books:\n");
            Present(Syfy);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Fantasy Books:\n");
            Present(Action);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Horror Books:\n");
            Present(Fantasy);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Criminal Books:\n");
            Present(Kids);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Western Books:\n");
            Present(Cooking);
        }

        public void StoreOnShelf(Book book)
        {
            switch (book.Genre)
            {
                case Genre.SYFY:
                    Syfy.Add(book);
                    break;
                case Genre.ACTION:
                    Action.Add(book);
                    break;
                case Genre.FANTASY:
                    Fantasy.Add(book);
                    break;
                case Genre.KIDS:
                    Kids.Add(book);
                    break;
                case Genre.COOKING:
                    Cooking.Add(book);
                    break;
            }
        }
        public Book CreateBook()
        {
            var book = new Book();
            Console.Write("Please enter books title: ");
            book.Title = Console.ReadLine();
            Console.Write("Please enter number for books genre (Syfy - 1, Action - 2, Fantsy - 3, Kids - 4, Cooking - 5): ");
            book.Genre = (Genre)Int32.Parse(Console.ReadLine());
            Console.Write("Please enter books author: ");
            book.Author = Console.ReadLine();
            Console.Write("Please enter books discription: ");
            book.Description = Console.ReadLine();
            Console.Write("Please enter number of pages: ");
            book.NumberOfPages = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Book added");

            return book;
        }
     
        public void Present(List<Book> listBooks)
        {
            foreach (Book book in listBooks)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Genre: {book.Genre}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine($"Number of pages: {book.NumberOfPages}");
            }
        }
    }
}
