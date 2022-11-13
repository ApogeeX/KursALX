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
                Console.WriteLine("Please choose action: \nA - Add book \nS - Show Shelves \nQ - Quit");
                Console.Write("Action: ");
                var choice = Console.ReadKey().KeyChar;
                switch (choice.ToString().ToLower())
                {
                    case "a":
                        while (true)
                        {
                            var book = bookStorageService.AddBook();
                            bookStorageService.StoreOnShelf(book);
                            Console.Write("Do you wish to add another book? (Y/N): ");
                            var yesNo = Console.ReadKey().KeyChar;
                            if (yesNo.ToString().ToLower() == "n")
                            {
                                break;
                            }
                        }
                        break;
                    case "s":
                        bookStorageService.ShowShelves();
                        break;
                    case "q":
                        break;
                }
                Console.WriteLine();
                Console.Write("Return to Main menu (M) or Quit (Q): ");
                var menuOrQuit = Console.ReadKey().KeyChar;
                if (menuOrQuit.ToString().ToLower() == "q")
                {
                    break;
                }
            }
        }
    }
}
