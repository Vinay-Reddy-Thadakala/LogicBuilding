using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class LeftTiltedParallelogramStarPattern
    {
        static void Main(string[] args)
        {
            int n, i, j, k;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n; i >= 1; i--)
            {
                for (k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
