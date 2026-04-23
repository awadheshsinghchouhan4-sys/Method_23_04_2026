using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class mthod_Task1_23_04_2026_Q1_calculator
    {
       public  static float  Addition(float num1, float num2)
        {
            return num1 + num2;
        }


        public static float Substraction(float num1 , float  num2)
        {
            return num1 - num2;
        }


        public static Double Multiplication(float num1,float num2)
        {
            return num1 * num2;
        }


        public static Double Division(float num1, float num2)
        {
            return num1 / num2;
        }

        public static  void Display()
        {
            bool satus = true;

            while (satus)
            {

                Console.Write(" Enter the number1: ");
                float num1 = Convert.ToSingle(Console.ReadLine());
                Console.Write(" Enter the Number2: ");
                float num2 = Convert.ToSingle(Console.ReadLine());
                Console.Write(" For Addition +  \n For Division  / \n For Substraction  - \n For Multiplication * \n");
                Console.WriteLine();
                string opt = Console.ReadLine();

                switch (opt)
                {
                    case "+":
                        Console.WriteLine(" The Addition of Two number is :" + Addition(num1, num2));
                        break;

                    case "-":
                        Console.WriteLine(" The Addition of Two number is :" + Substraction(num1, num2));
                        break;

                    case "*":
                        Console.WriteLine(" The Addition of Two number is :" + Multiplication(num1, num2));
                        break;

                    case "/":
                        Console.WriteLine(" The Addition of Two number is :" + Division(num1, num2));
                        break;

                    default:
                        Console.WriteLine(" invalid options");
                        break;
                }
                Console.WriteLine(" You want again to perform press Y (for yes) N (for Exit)");
                string choice= Console.ReadLine().ToUpper();
                if (choice =="N")
                {
                    Console.Write("Exit \n Thankyou");
                    satus = false;
                    break;
                }


            }

        }



        public static void Main(string[] args)
        {
            Display();
        }
    }
}
