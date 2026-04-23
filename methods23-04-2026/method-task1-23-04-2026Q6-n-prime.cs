using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_task1_23_04_2026Q6_n_prime
    {
        public static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.Write(" Enter the  starting Number to check the Prime Number : ");
            int starting = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the  ending Number to check the Prime Number : ");
            int endingnumber = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int number = starting; number <= endingnumber; number++)
            {

            if (IsPrime(number))
            {
                Console.WriteLine($" {number} prime");
                    count += 1;

            }

            }
            Console.WriteLine(" The total prime Number is :"+count);
        }
    }
}
