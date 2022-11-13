using KursALX.Lessons.M2.L2.Interfaces;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class PolishHello : IHello
    {
        public void SayGoodMoring(string name)
        {
            Console.WriteLine($"Dzień dobry {name}!");
        }

        public void SayGoodMoring()
        {
            Console.WriteLine($"Dzień dobry!");
        }

        public void SayHello()
        {
            Console.WriteLine("Cześć!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Cześć {name}!");
        }
    }
}
