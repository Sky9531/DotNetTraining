using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinMaxAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 12, 20, 33, 7, 15 };

            double average = numbers.Average();
            int minValue = numbers.Min();
            int maxValue = numbers.Max();

            Console.WriteLine("Average value of array elements: " + average);
            Console.WriteLine("Minimum value in the array: " + minValue);
            Console.WriteLine("Maximum value in the array: " + maxValue);
            Console.ReadLine();
        }
    }
}
