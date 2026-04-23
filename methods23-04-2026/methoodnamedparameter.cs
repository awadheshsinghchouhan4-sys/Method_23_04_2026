using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods23_04_2026
{
    internal class methoodnamedparameter
    {

        public static void DisplayInfo(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }
        public static void Main(string[] args)
        {
            DisplayInfo(name: "Alice", age: 30, city: "New York");
            DisplayInfo(city: "Los Angeles", name: "Bob", age: 25);
            Console.WriteLine("hellow");
        }
    }
}
