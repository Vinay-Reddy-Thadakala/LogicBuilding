using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class PrintFactorsOfANumber
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
        }
    }
}
