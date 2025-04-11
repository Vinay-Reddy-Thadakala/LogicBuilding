using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoopsPatterns
{
    class PyramidRepeatNumberPatternDesc
    {
        static void Main(string[] args)
        {
            int n, i, j, k;

            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = n; i >= 1; i--)
            {
                for (k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (j = n; j >= i; j--)
                {
                    Console.Write(i + " ");
                    
                }

                Console.WriteLine();
            }
        }
    }
}
