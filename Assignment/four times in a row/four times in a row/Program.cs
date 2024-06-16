using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace four_times_in_a_row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a digit:");
            int number = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);

      
            Console.WriteLine("{0} {0} {0} {0}", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.ReadLine();
        }
    }
}
