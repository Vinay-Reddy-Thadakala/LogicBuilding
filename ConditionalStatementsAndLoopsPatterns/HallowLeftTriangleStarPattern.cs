using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class HallowLeftTriangleStarPattern
    {
        static void Main(string[] args)
        {
            int n, i, j, k;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (k = 2 * (n - i); k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                {
                    if ((i == 3) && (j == 2))
                    {
                        Console.Write("  ");
                        continue;
                    }
                    else if ((i == 4) && (j == 2 || j == 3))
                    {
                        Console.Write("  ");
                        continue;
                    }
                    else
                    {
                        Console.Write("* ");
                    }                        
                }

                Console.WriteLine();
            }
        }
    }
}
