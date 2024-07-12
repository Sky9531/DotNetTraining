using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());


            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);
            Console.ReadLine();
        }
    }
}
