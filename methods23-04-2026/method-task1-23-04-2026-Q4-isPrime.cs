using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_task1_23_04_2026_Q4_isPrime
    {
        public  static bool IsPrime(int num)
        {
            if (num==0 || num==1)   
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            Console.Write(" Enter the Number to check the Prime Number : ");
            int number=Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine($" Number {number} is prime ");

            }
            else
            {
                Console.WriteLine($" Number {number} is not-prime ");
            }
        }
    }
}
