namespace KursALX.Assigments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            BookStorageService bookStorageService = new BookStorageService();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please choose action: \na - Add book \ns - Show Shelves \nq - Quit");
                Console.Write("Action: ");
                var choice = Console.ReadKey();
                switch (choice.KeyChar)
                {
                    case 'a':
                        while (true)
                        {
                            var book = bookStorageService.AddBook();
                            bookStorageService.StoreOnShelf(book);
                            Console.Write("Do you wish to add another book? (y/n): ");
                            var yesNo = Console.ReadKey();
                            if (yesNo.KeyChar == 'n')
                            {
                                break;
                            }
                        }
                        break;
                    case 's':
                        bookStorageService.ShowShelves();
                        break;
                    case 'q':
                        break;
                }
                Console.WriteLine();
                Console.Write("Return to main menu (m) or quit (q): ");
                var menuOrQuit = Console.ReadKey();
                if (menuOrQuit.KeyChar == 'q')
                {
                    break;
                }
            }
        }
    }
}
