using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class HallowSquareStarPattern
    {
        static void Main(string[] args)
        {
            int n, i, j;

            Console.Write("Enter number of rows: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if ((i == 2 || i == 3 || i == 4) && (j == 2 || j == 3 || j == 4))
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
