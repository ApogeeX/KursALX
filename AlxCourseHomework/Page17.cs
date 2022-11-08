using AlxCourseHomework.MaterialsAssignments;

namespace AlxCourseHomework
{
    public class Page17
    {
        public static void Run()
        {
            var maths1 = new Maths(2, 6, 15);

            Maths.Present(maths1.A, maths1.B, maths1.C);

            Maths.DeMorgan();
        }
    }
}
