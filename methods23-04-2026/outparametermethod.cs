using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class outparametermethod
    {
        public static void Sum( int num1, int num2,out int sum)
        {
            sum=num1 + num2;
        }

        public static void Main(string[] args)
        {
            int a, b, c;
            a = 10;
            b = 40;
            Sum(a, b,out  c);
            Console.WriteLine(c);
        }
    }
}
