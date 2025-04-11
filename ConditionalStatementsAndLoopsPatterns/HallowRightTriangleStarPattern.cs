using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class HallowRightTriangleStarPattern
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
