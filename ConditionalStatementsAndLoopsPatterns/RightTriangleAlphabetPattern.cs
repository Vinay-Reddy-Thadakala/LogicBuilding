using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class RightTriangleAlphabetPattern
    {
        static void Main(string[] args)
        {
            int n, i, j;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(Convert.ToChar(j + 64) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
