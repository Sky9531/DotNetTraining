using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndTriple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            if (firstNumber == secondNumber)
            {
                sum *= 3;
            }

            Console.WriteLine("The result is: " + sum);
            Console.ReadLine();
        }
    }
}
