using AlxCourseHomework.MaterialsAssignments.Enums;

namespace AlxCourseHomework
{
    public class Page25
    {
        public static void EnumRun()
        {
            Console.WriteLine($"Miesiące z enum'a Months:");
            foreach (var p in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(p);
            }
            
        }

        public static void ListRun()
        {
            List<string> monthsList = new List<string>();

            monthsList.Add("Styczeń");
            monthsList.Add("Luty");
            monthsList.Add("Marzec");
            monthsList.Add("Kwiecień");
            monthsList.Add("Maj");
            monthsList.Add("Czerwiec");
            monthsList.Add("Lipiec");
            monthsList.Add("Sierpień");
            monthsList.Add("Wrzesień");
            monthsList.Add("Październik");
            monthsList.Add("Listopad");
            monthsList.Add("Grudzień");

            Console.WriteLine($"Miesiące z listy monthsList:");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(monthsList[i]);
            }
        }
    }
}
