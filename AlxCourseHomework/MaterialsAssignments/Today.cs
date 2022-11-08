using AlxCourseHomework.MaterialsAssignments.Enums;

namespace AlxCourseHomework.MaterialsAssignments
{
    public class Today
    {
        public int Day;
        public int Month;
        public int Year;

        public Today(int day, int month, int year)
        {
            Day = day;  
            Month = month;
            Year = year;
        }
 
        public static void Present(int day, int month, int year)
        {
            Days dayName = (Days)day;
            Months monthName = (Months)month;
            Console.WriteLine($"------ Day and Month from Enums ------");
            Console.WriteLine($"Today is: {dayName} {DateTime.Now.Day}");
            Console.WriteLine($"Month: {monthName}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"---------------- END ----------------");
            Console.WriteLine("");
        }
    }
}
