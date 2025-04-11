using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class PrintSeriesOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter range from 2 to ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i}, ");
                }
            }

            //Another method
            //int n;

            //Console.Write("Enter range from 2 to ");
            //n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"{i}, ");
            //    i++;
            //}
        }
    }
}
