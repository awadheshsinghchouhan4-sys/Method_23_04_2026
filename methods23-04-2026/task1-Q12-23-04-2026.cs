using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class task1_Q12_23_04_2026
    {
        public static void PrintEmployeeDetails(string name, int id, int salary)
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Salary: {salary}");
        }
        public static void Main(string[] args)
        {
            PrintEmployeeDetails("John Doe", 12345, 50000);
            PrintEmployeeDetails(name:"Awadhesh Singh Chouhan",id:1284,salary:90086);
        }
    }
}
