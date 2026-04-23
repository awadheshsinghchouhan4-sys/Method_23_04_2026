using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class optionalparameter
    {
        public  static void Wish(string name="Guest")
        {
            Console.WriteLine($" Hello {name} Welcome to C# Programming ");
        }

        public static void Main(string[] args)
        {
            Wish("John");
            Wish();
        }
    }
}
