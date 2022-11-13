using KursALX.Lessons.M2.L2.Classes;
using KursALX.Lessons.M2.L2.Interfaces;

namespace KursALX.Lessons.M2.L2
{
    public class L2Interfaces
    {
        public static void Run()
        {
            IHello helloService = new PolishHello();
            helloService.SayHello();
            helloService.SayHello("Emil");
            helloService.SayGoodMoring();
            helloService.SayGoodMoring("Emil");
            Console.WriteLine();
            helloService = new Hello();
            helloService.SayHello();
            helloService.SayHello("Emil");
            helloService.SayGoodMoring();
            helloService.SayGoodMoring("Emil");
        }
    }
}
