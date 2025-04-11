using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class ReverseTheDigitsOfANumber
    {
        static void Main(string[] args)
        {
            int number, temp, remainder, reverse = 0;

            Console.Write("Enter any number: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;

            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine($"Reverse of {temp} = {reverse}");
        }
    }
}
