using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_task1_23_04_2026__Q2_Fullname
    {
        public static string FullName(string firstName,string middleName, String lastName)
        {
            return firstName + middleName + lastName;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter The First Name : ");
            string firstName = Console.ReadLine();

            Console.Write("Enter The Middle Name : ");
            string middleName = Console.ReadLine();

            Console.Write("Enter The last Name : ");
            string lastName = Console.ReadLine();

            string fullNameUser = FullName(firstName, middleName, lastName);

            Console.WriteLine("The Given full name is  " + fullNameUser);
        }
    }
}
