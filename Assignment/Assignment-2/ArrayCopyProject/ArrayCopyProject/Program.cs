using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = new int[array1.Length];

            
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            
            Console.WriteLine("Elements of array2:");
            foreach (int element in array2)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
