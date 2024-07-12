using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[10];
            int total = 0;
            int minMarks = int.MaxValue;
            int maxMarks = int.MinValue;

            Console.WriteLine("Enter ten marks:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter mark {0}: ", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());

                total += marks[i];

                if (marks[i] < minMarks)
                {
                    minMarks = marks[i];
                }

                if (marks[i] > maxMarks)
                {
                    maxMarks = marks[i];
                }
            }

            double average = (double)total / 10;

            Array.Sort(marks);
            Array.Reverse(marks);

            Console.WriteLine("Total marks: " + total);
            Console.WriteLine("Average marks: " + average);
            Console.WriteLine("Minimum marks: " + minMarks);
            Console.WriteLine("Maximum marks: " + maxMarks);

            Console.WriteLine("Marks in ascending order:");
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Marks in descending order:");
            foreach (int mark in marks.Reverse())
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
