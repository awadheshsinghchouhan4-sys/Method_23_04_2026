using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace methods23_04_2026
{
    internal class task_23_04_2026Q9
    {

        /*Accept name of person and marks.then you need to display name and total marks*/

        public static void StudentDetails(out int totalMark, string name = "not given", params int[] marks)
        {
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];
            }
            totalMark= total;

        }

        public static void Main(string[] args)
        {
            int totalmarks = 0;
            Console.WriteLine(" Enter The Name of the Students : ");
            string StudentName = Console.ReadLine();
            int[] subjectMarks = new int[4];
            for (int i = 0; i < subjectMarks.Length; i++) 
            {
                Console.WriteLine(" Enter the marks of subject :");
                subjectMarks[i] = Convert.ToInt32(Console.ReadLine());
            }


            StudentDetails(out totalmarks , StudentName, subjectMarks);
            Console.WriteLine($" The Name of student is {StudentName} and the marks is {totalmarks}");
        }
    }
}
