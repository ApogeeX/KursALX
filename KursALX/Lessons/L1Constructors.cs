using KursALX.Lessons.Classes;

namespace KursALX.Lessons
{
    public class L1Constructors
    {
        public static void Test()
        {
            var spider = new Spider();
            spider.Color = "Black";
            spider.Species = "Black Widow";
            spider.IsVenomous = true;
            spider.Sex = "Male";
            spider.Present();

            var redSpider = new Spider("Red", "Tarantula", false, "Female");
            redSpider.Present();

            var blueSpider = new Spider("Blue", "Golliath");
            blueSpider.Present();

            var yellowSpider = new Spider("Yellow", false);
            yellowSpider.Present();
        }
    }
}
