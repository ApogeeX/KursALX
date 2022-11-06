namespace AlxCourseHomework.MaterialsAssignments
{
    public class Maths
    {
        public int A;
        public int B;
        public int C;

        public Maths(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static void Present(int a, int b, int c)
        {
            Console.WriteLine($"------ Maths ((a ^ b) / 2) % c ------");
            Console.WriteLine($"For a: {a}");
            Console.WriteLine($"For b: {b}");
            Console.WriteLine($"For c: {c}");
            Console.WriteLine($"((a ^ b) / 2) % c = {((a ^ b) / 2) % c}");
            Console.WriteLine("-------------- End Maths --------------");
            Console.WriteLine("");
            Console.WriteLine($"------------ Check If > ------------");
            bool check = a + 5 > a;
            Console.WriteLine($"Check if a + 5 > a: {check}");
            Console.WriteLine("----------- End Check If ------------");
            Console.WriteLine("");
        }

        public static void DeMorgan()
        {
            bool pTrue = true;
            bool pFalse = false;
            bool qTrue = true;
            bool qFalse = false;
            bool check1 = !(pTrue | qTrue) == (!pTrue & !qTrue);
            bool check2 = !(pTrue & qTrue) == (!pTrue | !qTrue);
            bool check3 = !(pTrue | qFalse) == (!pTrue & !qFalse);
            bool check4 = !(pTrue & qFalse) == (!pTrue | !qFalse);
            bool check5 = !(pFalse | qTrue) == (!pFalse & !qTrue);
            bool check6 = !(pFalse & qTrue) == (!pFalse | !qTrue);
            bool check7 = !(pFalse | qFalse) == (!pFalse & !qFalse);
            bool check8 = !(pFalse & qFalse) == (!pFalse | !qFalse);
            bool check9 = check1 == true && check2 == true && check3 == true && check4 == true && check5 == true && check6 == true && check7 == true && check8 == true;

            Console.WriteLine($"------------------------ First Law of de Morgan ------------------------");
            Console.Write($"While p=true and q=true - check if "); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p | q) = !p & !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check1}");
            Console.Write($"While p=true and q=true - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p & q) = !p | !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check2}");
            Console.Write($"While p=true and q=false - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p | q) = !p & !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check3}");
            Console.Write($"While p=true and q=false - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p & q) = !p | !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check4}");
            Console.Write($"While p=false and q=true - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p | q) = !p & !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check5}");
            Console.Write($"While p=false and q=true - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p & q) = !p | !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check6}");
            Console.Write($"While p=false and q=flase - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p | q) = !p & !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check7}");
            Console.Write($"while p=false and q=false - check if ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!(p & q) = !p | !q ");
            Console.ResetColor();
            Console.WriteLine($"is true? - {check8}");
            Console.WriteLine($"Check if all above is true? - {check9}");
            if (check9 == true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("* The complement of the union of two sets is the same as the intersection of their complements");
                Console.WriteLine("* The complement of the intersection of two sets is the same as the union of their complements");
                Console.ResetColor();
            }
            else { Console.WriteLine("Not going to happen!"); }
            Console.WriteLine($"--------------------------- End of de Morgan ---------------------------");
            Console.WriteLine("");
        }
    }
}
