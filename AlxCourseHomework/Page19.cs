using AlxCourseHomework.MaterialsAssignments;

namespace AlxCourseHomework
{
    public class Page19
    {
        public static void Run()
        {
            Console.WriteLine($"---------------- If Conditional ----------------"); 
            Console.Write("Enter total sum in basket (for If method): ");
            int basketIf = Int32.Parse(Console.ReadLine());
            SetDiscount.IfSet(basketIf);
            Console.WriteLine("-------------- End If Conditional --------------");
            Console.WriteLine("");

            Console.WriteLine($"---------------- Switch Case ----------------");
            Console.Write("Enter total sum in basket (for Switch method): ");
            int basketSwitch = Int32.Parse(Console.ReadLine());
            SetDiscount.SwitchSet(basketSwitch);
            Console.ResetColor();
            Console.WriteLine("-------------- End Switch Case --------------");
            Console.WriteLine("");
        }                
    }
}
