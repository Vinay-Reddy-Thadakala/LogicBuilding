using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class DiamondNumberPattern
    {
        static void Main(string[] args)
        {
            int n, i, j, k;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (k = n - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }

            for (i = n - 1; i >= 1; i--)
            {
                for (k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
