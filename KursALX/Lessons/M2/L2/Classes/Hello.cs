using KursALX.Lessons.M2.L2.Interfaces;

namespace KursALX.Lessons.M2.L2.Classes
{
    public class Hello : IHello
    {
        public void SayGoodMoring(string name)
        {
            Console.WriteLine($"Good Morning {name}!");
        }

        public void SayGoodMoring()
        {
            Console.WriteLine($"Good Morning!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
