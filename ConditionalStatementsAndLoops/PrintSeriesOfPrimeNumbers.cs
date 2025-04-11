using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class PrintSeriesOfPrimeNumbers
    {
        static void Main(string[] args)
        {
            int n, count = 0;

            Console.Write("Enter range from 2 to ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if(count == 2)
                {
                    Console.Write($"{i}, ");
                }
                count = 0;
            }
        }
    }
}
