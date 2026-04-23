using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class methodtaskQ9_23_04_2026
    {
        public static void CalculateDiscount(int amount, out double sgst,out double cgst)
        {
            sgst = amount * 0.03;
            cgst = amount * 0.05;


        }

        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter the Amount of the Customer :");
            int amount=Convert.ToInt32(Console.ReadLine());

            double totalAmount = 0;
            double cgstTotalAmount = 0;
            double sgstTotalAmount = 0;

            CalculateDiscount(amount, out sgstTotalAmount, out cgstTotalAmount);

            totalAmount = amount + sgstTotalAmount + cgstTotalAmount;
            Console.WriteLine("The Cgst Charge is :"+ cgstTotalAmount);
            Console.WriteLine("The Cgst Charge is :"+ sgstTotalAmount);
            Console.WriteLine( $" The total charge is : {totalAmount}");


        }
    }
}
