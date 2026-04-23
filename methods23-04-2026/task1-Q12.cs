using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class task1_Q12
    {
        public static void PrintEmployeeDetails(string name, string city)
        {
            Console.WriteLine("The user Branch is " + name + " " + city);
        }

        public static void Main(string[] args)
        {
            PrintEmployeeDetails("Awadhesh Singh Chouhan", "Indore");
            PrintEmployeeDetails(name: "John Doe", city: "New York");
        }
    }
}
