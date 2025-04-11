using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CheckNumberIsEvenOrOdd
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is even number.");
            }
            else
            {
                Console.WriteLine(n + " is odd number.");
            }
        }
    }
}
