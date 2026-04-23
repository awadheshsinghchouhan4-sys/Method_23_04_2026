using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_task1_23_02_2026_Q3_Area_circle
    {

        public double Area_Of_Circle(double radius)
        {
            double Pi = 3.14;

            return Pi * radius*radius;
        }
        public static void Main(string[] args)
        {
            Console.Write(" Enter the Radius of Circle :");
            double radius = Convert.ToDouble(Console.ReadLine());

            method_task1_23_02_2026_Q3_Area_circle R = new method_task1_23_02_2026_Q3_Area_circle();

            double result =R.Area_Of_Circle(radius);
            Console.WriteLine(" The Area of circle is :"+ result);
        }
    }
}
