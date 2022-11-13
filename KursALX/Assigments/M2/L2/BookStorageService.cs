using System.Globalization;

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
        public void ShowShelves()
        {
            Console.Clear();
            Console.WriteLine("------------------- 1. Syfy Books --------------------");
            Console.WriteLine($"Number of elements: {Syfy.Count}");
            Console.WriteLine();
            Console.WriteLine("------------------ 2. Action Books -------------------");
            Console.WriteLine($"Number of elements: {Action.Count}");
            Console.WriteLine();
            Console.WriteLine("----------------- 3. Fantasy Books -------------------");
            Console.WriteLine($"Number of elements: {Fantasy.Count}");
            Console.WriteLine();
            Console.WriteLine("------------------- 4. Kids Books --------------------");
            Console.WriteLine($"Number of elements: {Kids.Count}");
            Console.WriteLine();
            Console.WriteLine("----------------- 5. Cooking Books -------------------");
            Console.WriteLine($"Number of elements: {Cooking.Count}");
            Console.WriteLine();
            Console.WriteLine("Choose shelve (1-5) for details or 6 for more options:");
            Console.WriteLine("1 - Syfy");
            Console.WriteLine("2 - Action");
            Console.WriteLine("3 - Fantasy");
            Console.WriteLine("4 - Kids");
            Console.WriteLine("5 - Cooking");
            Console.WriteLine("6 - More options");
            var shelve = CharUnicodeInfo.GetDecimalDigitValue(Console.ReadKey().KeyChar);
            if (shelve == 6)
            {
            }
            else if (shelve == 1)
            {
                Console.Clear();
                Console.WriteLine("------------------- 1. Syfy Books --------------------");
                Present(Syfy);
            }
            else if (shelve == 2)
            {
                Console.Clear();
                Console.WriteLine("------------------ 2. Action Books -------------------");
                Present(Action);
            }
            else if (shelve == 3)
            {
                Console.Clear();
                Console.WriteLine("----------------- 3. Fantasy Books -------------------");
                Present(Fantasy);
            }
            else if (shelve == 4)
            {
                Console.Clear();
                Console.WriteLine("------------------- 4. Kids Books --------------------");
                Present(Kids);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("----------------- 5. Cooking Books -------------------");
                Present(Cooking);
            }
        }

        public void StoreOnShelf(Book book)
        {
            switch (book.Genre)
            {
                case Genre.Syfy:
                    Syfy.Add(book);
                    break;
                case Genre.Action:
                    Action.Add(book);
                    break;
                case Genre.Fantasy:
                    Fantasy.Add(book);
                    break;
                case Genre.Kids:
                    Kids.Add(book);
                    break;
                case Genre.Cooking:
                    Cooking.Add(book);
                    break;
            }
        }
        public Book AddBook()
        {
            var book = new Book();
            Console.Clear();
            Console.WriteLine("----------------- Add Book --------------");
            Console.Write("Please enter books title: ");
            book.Title = Console.ReadLine();
            Console.Write("Please enter number for books genre \n1 - Syfy \n2 - Action \n3 - Fantasy \n4 - Kids \n5 - Cooking\n");
            book.Genre = (Genre)CharUnicodeInfo.GetDecimalDigitValue(Console.ReadKey().KeyChar); //gets char and returns int
            Console.WriteLine();
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
                Console.WriteLine();
            }
        }
    }
}
