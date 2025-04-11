using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class FindLargestAmongThreeNumbers
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("{0} is the largest number", a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is the largest number", b);
            }
            else
            {
                Console.WriteLine("{0} is the largest number", c);
            }
        }
    }
}
