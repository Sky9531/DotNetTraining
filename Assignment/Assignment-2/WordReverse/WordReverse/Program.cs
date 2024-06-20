using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reversedWord = ReverseString(word);
            Console.WriteLine($"The reverse of the word '{word}' is: {reversedWord}");

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
