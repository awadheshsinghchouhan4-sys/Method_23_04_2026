using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_task1_23_02_2026_Q5_total_marks
    {
        public static int  Total_marks(int[] marks)
        {
            int totalSum = 0;
            for (int i = 0;i<marks.Length; i++)
            {
                totalSum += marks[i];
            }
            return totalSum;
        }
        public static void Main(string[] args)
        {

            int[] marks = new int[5];

            for (int i=0;i<marks.Length;i++) 
                {
                Console.WriteLine($" Enter the subjec {i+1} marks");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                }


            int result = Total_marks(marks);
            Console.WriteLine($"The Total marks is {result}");

        }

    }
}
