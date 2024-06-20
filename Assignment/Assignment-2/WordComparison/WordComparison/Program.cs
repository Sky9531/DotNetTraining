using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();

            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            if (string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
            Console.ReadLine();
        }
    }
}
