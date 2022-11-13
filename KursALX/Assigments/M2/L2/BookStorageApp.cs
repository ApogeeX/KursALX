namespace KursALX.Assigments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            var bookStorageService = new BookStorageService();
            char question='y';
            do
            {
                var book = new Book();
            }
            while(question=='y');
        }

        public static void PresentShelve(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
