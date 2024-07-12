using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCA_3
{
    internal class Cricket
    {
        public void Pointscalculation(int matches)
        {
            int[] scores = new int[matches];
            int sum = 0;

            for (int i = 0; i < matches; i++)
            {
                Console.Write($"Enter the score of match {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                sum += scores[i];
            }

            double average = (double)sum / matches;

            Console.WriteLine($"Sum of scores is: {sum}");
            Console.WriteLine($"Average score is: {average:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total number of matches Played: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Cricket cricket = new Cricket();
            cricket.Pointscalculation(n);
            Console.ReadLine();
        }
   
    }
    
    
}
