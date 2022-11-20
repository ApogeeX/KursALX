using AlxCourseHomework.MaterialsAssignments.Classes;

namespace AlxCourseHomework
{
    public class Page45
    {
        public static void Cars()
        {
            Car audiA5 = new Car("Audi A5", 12000, 17000, 3000, 35000, 15000, 23);
            Car toyotaPrius = new Car("Toyota Prius", 99000, 23);
            toyotaPrius.AutomaticWindows = 2000;
            toyotaPrius.AluWheels = 18000;                
            Car kiaCeed = new Car("Kia Ceed", 44000,  23);
            kiaCeed.AutomaticWindows = 2000;
            kiaCeed.AutomaticTransmision = 20000;

            audiA5.ValueOfAdditions();
            toyotaPrius.ValueOfAdditions();
            kiaCeed.ValueOfAdditions();
        }

        public static void Guest()
        {
            Guest guest1 = new Guest("Jan", "Kowalski");
            Guest guest2 = new Guest("Urszula", "Jakastam");

            guest1.GreetGuest();
            guest2.GreetGuest();
        }
    }
}
