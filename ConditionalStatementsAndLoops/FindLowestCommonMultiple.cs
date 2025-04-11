using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindLowestCommonMultiple
    {
        static void Main(string[] args)
        {
            int num1, num2, lowestCommonMultiple;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            lowestCommonMultiple = (num1 > num2) ? num1 : num2;

            while (true)
            {
                if (lowestCommonMultiple % num1 == 0 && lowestCommonMultiple % num2 == 0)
                {
                    Console.WriteLine($"LCM of {num1} and {num2} is {lowestCommonMultiple}");
                    break;
                }

                lowestCommonMultiple++;
            }
            
        }
    }
}
