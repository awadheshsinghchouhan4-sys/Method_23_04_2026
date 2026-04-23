using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_23_04_2026_taskQ8
    {


        public static void StudentDetails(int subject1, int subject2, int subject3, out int total, out int avg )
        {
            total = 0;
            avg = 0;
            total = subject1 + subject2 + subject3;
            avg = total / 3;
        }

        public static void Main(string[] args)
        {
            Console.Write(" Enter the mark of subject 1 :");
            int subjectmark1= Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the mark of subject 2 :");
            int subjectmark2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the mark of subject 3 :");
            int subjectmark3 = Convert.ToInt32(Console.ReadLine());

            int total;
            int avg;
            StudentDetails(subjectmark1, subjectmark2, subjectmark3, out total, out avg);

            Console.WriteLine($" Average  mark is {avg} and the total marks is {total}");
        }
    }
}
