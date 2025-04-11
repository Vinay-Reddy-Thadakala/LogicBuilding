using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FizzBuzzProblem
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter upper limit for fizzbuzz: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i + " - " + "FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " - " + "Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " - " + "Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
