using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindSquareOfANumber
    {
        static void Main(string[] args)
        {
            int n, square = 1;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 2; i++)
            {
                square *= n;
            }

            Console.WriteLine($"Square of {n} is {square}");
        }
    }
}
