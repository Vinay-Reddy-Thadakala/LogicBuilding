using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindSumOfNaturalNumbers
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Enter range from 1 to ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of natural numbers from 1 to {n} is {sum}");
        }
    }
}
