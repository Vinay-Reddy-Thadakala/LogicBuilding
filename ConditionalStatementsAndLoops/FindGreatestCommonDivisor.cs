using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindGreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int num1, num2, highestCommonFactor = 0;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num1 || i <= num2; i++)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    highestCommonFactor = i;
                }
            }

            Console.WriteLine($"HCF of {num1} and {num2} is {highestCommonFactor}");
        }
    }
}
