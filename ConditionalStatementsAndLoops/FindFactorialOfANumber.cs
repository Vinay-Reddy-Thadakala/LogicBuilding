using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindFactorialOfANumber
    {
        static void Main(string[] args)
        {
            int n, fact = 1;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                fact *= i;
            }

            Console.WriteLine($"Factorial of {n} is {fact}");
        }
    }
}
