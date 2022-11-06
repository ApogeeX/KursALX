using System.Drawing;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class PersonalData
    {
        public string Name;
        public string Surname;
        public int Age;
        public double Height;
        public string Sex;
        public long Pesel;

        public PersonalData(string name, string surname, int age, double height, string sex, long pesel)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Height = height;
            Sex = sex;
            Pesel = pesel;
        }

        public static void Present(string name, string surname, int age, double height, string sex, long pesel)
        {
            Console.WriteLine("----- Personal Data -----");
            Console.WriteLine($"Name {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}m");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"PESEL: {pesel}");
            Console.WriteLine("--- End Personal Data ---");
            Console.WriteLine("");
            Console.WriteLine("----- Personal Data With Convertion-----");
            Console.WriteLine($"Name {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age}");
            //int intHeight = (int)height;
            Console.WriteLine($"Height: {(int)height}m");
            Console.WriteLine($"Sex: {sex}");
            Console.WriteLine($"PESEL: {pesel}");
            Console.WriteLine("---------- End Personal Data -----------");
            Console.WriteLine("");
        }
    }    
}
