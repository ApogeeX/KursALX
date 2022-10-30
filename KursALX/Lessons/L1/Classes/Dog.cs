namespace KursALX.Lessons.L1.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool GoodGrl;
        public string SheHe;

        public void Jump()
        {
            Console.WriteLine("Boing! Boing!");
        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public int GetOlderAge()
        {
            return Age + 1;
        }

        public void GrowOlder(int numberOfYears)
        {
            Age = Age + numberOfYears;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public DogOffspringStats Breed()
        {
            DogOffspringStats dogStats = new DogOffspringStats();
            dogStats.NumberOfMalePups = 5;
            dogStats.NumberOfFemalePups = 4;
            return dogStats;
        }

        public void Present()
        {
            Console.WriteLine("Attension here is " + Name + " the dog");
            Console.WriteLine(SheHe + " is a " + Race);
            Console.WriteLine(SheHe + " is " + Age + " years old");
            Console.WriteLine("Is " + SheHe + " a good girl?: " + GoodGrl);
        }


    }
}
