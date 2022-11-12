using KursALX.Assigments.Classes;
using System.Xml.Linq;

namespace KursALX.Assigments.M1
{
    public class AssigmentsDemo
    {
        public static void Run()
        {
            var book1 = new Book();
            book1.Title = "HP1";
            book1.Author = "J.K. Rowiling";
            book1.HardCover = true;
            book1.Pages = 355;

            book1.Present();
            book1.OpenBook();

            var tcgCard1 = new TCGCard("Pokemon", true, 315, "Charmadon");

            var tcgCard2 = new TCGCard(600);
            tcgCard2.GameTitle = "MTG";

            tcgCard1.Present();
            tcgCard1.Play();
            tcgCard2.Present();
            tcgCard2.Play();
        }
    }
}
