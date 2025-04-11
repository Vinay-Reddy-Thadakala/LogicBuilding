using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class PrintPrimeFactorsOfANumber
    {
        static void Main(string[] args)
        {
            int n, count = 0;

            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        Console.Write($"{i}, ");
                    }
                    count = 0;
                }
            }
        }
    }
}
