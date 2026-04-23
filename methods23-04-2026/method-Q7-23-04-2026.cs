using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class method_Q7_23_04_2026
    {


        public static void SumProduct(int num1, int num2, out int sum, out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;
        }

        public static void Main(string[] args)
        {
            Console.Write(" Enter the number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int sum, product;
            SumProduct(number1, number2, out sum, out product);

            Console.WriteLine($" The Sum of number is {sum} and the product is {product}");
        }
    }
}
