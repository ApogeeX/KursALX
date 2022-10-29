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

            var redSpider = new Spider("Red", "Tarantula", false, "Female");

            var blueSpider = new Spider("Blue", "Golliath");

            var yellowSpider = new Spider("Yellow", false);

        }
    }
}
