namespace AlxCourseHomework.MaterialsAssignments.Classes
{
    public class Guest
    {
        public string Name;
        public string Surname;

        public Guest(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void GreetGuest()
        {
            if (Name.ToLower().EndsWith("a"))
            {
                Console.WriteLine($"{Name} {Surname}");
                Console.WriteLine("Dzień dobry Pani");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{Name} {Surname}");
                Console.WriteLine("Dzień dobry Panu");
                Console.WriteLine();
            }
        }
    }
}
