using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class parammethod
    {
        public static int sum(params  int [] numbers )
            {
            int total = 0;
            foreach( int num in numbers )
            {
                total += num;
            }
            return total;
            }
        public static void Main( string[] args )
        {
            Console.WriteLine(sum(10,20,30));
            Console.WriteLine(sum(20,30,40));        }
             
    }
}
