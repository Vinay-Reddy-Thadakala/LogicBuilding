using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CheckNumberIsPositiveOrNegative
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n >= 0)
            {
                Console.WriteLine("{0} is positive number", n);
            }
            else
            {
                Console.WriteLine("{0} is negative number", n);
            }
        }
    }
}
