using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CountNumberOfDigitsInInteger
    {
        static void Main(string[] args)
        {
            int n, temp, count = 0;

            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;

            while(n != 0)
            {
                n = n / 10;
                count++;
            }

            Console.WriteLine($"Number on digits in {temp} = {count}");
        }
    }
}
