using System.ComponentModel.DataAnnotations;
using KursALX.Lessons.L1.Classes;

namespace KursALX.Lessons.L1
{
    public class L1ObjectVariables
    {
        public static void Test1()
        {
            Console.WriteLine("Variables");
            Dog dog = new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Beza";
            dog.Race = "Maltaniese";
            dog.Age = 4;
            Console.WriteLine("Attension here is " + dog.Name + " the dog");
            Console.WriteLine("She is a " + dog.Race);
            Console.WriteLine("She is " + dog.Age + " years old");
            Dog dogAzor = new Dog();
        }

        public static void Test2()
        {
            Dog maltanieseDog = new Dog();
            maltanieseDog.Race = "West";
            maltanieseDog.Age = 9;
            maltanieseDog.Name = "Fanta";
            maltanieseDog.GoodGrl = true;
            maltanieseDog.SheHe = "She";
            maltanieseDog.Present();
            DogOffspringStats stats = maltanieseDog.Breed();
            Console.WriteLine("Number of female pups: " + stats.NumberOfFemalePups);
            Console.WriteLine("Number of male pups: " + stats.NumberOfMalePups);
            maltanieseDog.Bark();
            maltanieseDog.Jump();
            Console.WriteLine(maltanieseDog.Add(4, 3));
        }

        public void WriteSomething()
        {
            Console.WriteLine("Write Something");
        }
    }
}
