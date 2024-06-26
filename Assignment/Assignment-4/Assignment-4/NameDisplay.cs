using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class NameDisplay
    {
        static void Main(string[] args)
        {
            
                string firstName = "Shivaraj";
                string lastName = "Patil";

                Display(firstName, lastName);
            
        }
        static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
            Console.ReadLine();
        }
    }
}
