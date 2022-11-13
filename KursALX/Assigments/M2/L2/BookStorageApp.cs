namespace KursALX.Assigments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            BookStorageService bookStorageService = new BookStorageService();
            while (true)
            {
                var book = bookStorageService.CreateBook();
                bookStorageService.StoreOnShelf(book);
                bookStorageService.Run();
                Console.Write("Do you want to continue (Yes/No):");
                string doYouWant = Console.ReadLine().ToLower();
                if (doYouWant == "no")
                {
                    break;
                }
            }
        }
    }
}
