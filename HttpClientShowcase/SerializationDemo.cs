using HttpClientShowcase.Models;
using Newtonsoft.Json;

namespace HttpClientShowcase
{
    public class SerializationDemo
    {
        public void Run()
        {
            var book = new Book
            {
                Id = 1,
                Title = "The Hogfather",
                Author = "Terry Prachett",
                Genre = "Fantasy"
            };

            var book2 = new Book
            {
                Id = 2,
                Title = "The Witcher",
                Author = "Andrzej Sapkowski",
                Genre = "Fantasy"
            };

            var bookJson = JsonConvert.SerializeObject(book);
            Console.WriteLine(bookJson);

            var bookBox = new BookBox
            {
                Id = 120,
                Book = book,
            };

            var bookBoxJson = JsonConvert.SerializeObject(bookBox);
            Console.WriteLine(bookBoxJson);

            var shelf = new List<Book>();
            shelf.Add(book);
            shelf.Add(book2);

            var bookShelf = new BookShelf
            {
                Id = 3,
                Books = shelf  
            };

            var bookShelfJson = JsonConvert.SerializeObject(bookShelf);
            Console.WriteLine(bookShelfJson);
        }
    }
}
