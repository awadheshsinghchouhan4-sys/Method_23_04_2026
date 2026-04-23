using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class Program
    {
        public static void Wish()
        {
            Console.WriteLine("hello wishing");
        }


        // methods with parameters and return value 

        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            // accecing the value to the instance

            Program p = new Program();
            //p.Wish();

            //calling through the static method

            //Wish();
            // void will not return the the value
            // it oly used for printing value

            // creating the objext of the methods 

            int sum=Add(10,20);
            Console.WriteLine("The sum is :"+sum);
            Console.ReadKey();
        }


    }
}
