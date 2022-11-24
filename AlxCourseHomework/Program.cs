using AlxCourseHomework;

int choiceInt = 1;
while (choiceInt != 0)
{
    Console.Clear();
    Console.WriteLine("1 - Personal Data");
    Console.WriteLine("2 - Today");
    Console.WriteLine("3 - If Conditional");
    Console.WriteLine("4 - Case Conditional");
    Console.WriteLine("5 - Maths and De Morgan");
    Console.WriteLine("6 - Email Service");
    Console.WriteLine("7 - Warehouse Service");
    Console.WriteLine("8 - Search in array");
    Console.WriteLine("9 - 3x3 array present");
    Console.WriteLine("10 - Array change");
    Console.WriteLine("11 - Months in Enum");
    Console.WriteLine("12 - Months in List");
    Console.WriteLine("13 - Cars");
    Console.WriteLine("14 - Guest");
    Console.WriteLine("15 - Workers");
    Console.WriteLine("0 - End program");
    Console.Write("Please choose assigment to test: ");

    var choiceString = Console.ReadLine();
    
    try
    {
        choiceInt = int.Parse(choiceString);
    }
    catch (Exception)
    {
        Console.WriteLine("Wrong choice.");
        choiceInt = 0;
    }
    
    switch (choiceInt)
    {
        case 0:
            Console.WriteLine("Program will close now. Press any key to continue.");
            Console.ReadKey();
            break;
        case 1:
            Page12.PersonalDataRun();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 2:
            Page12.TodayRun();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 3:
            Page19.IfRun();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 4:
            Page19.CaseRun();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 5:
            Page17.Run();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 6:
            Homework1Test.Run();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 7:
            Page21.Run();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 8:
            Page23.ArraySearch();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 9:
            Page23.Array3On3();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 10:
            Page23.ArrayChange();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 11:
            Page25.EnumRun();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 12:
            Page25.ListRun();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 13:
            Page45.Cars();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 14:
            Page45.Guest();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case 15:
            Console.Clear();
            Page46.Run();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Wrong choice, press any key to continue.");
            Console.ReadKey();
            break;
    }
}