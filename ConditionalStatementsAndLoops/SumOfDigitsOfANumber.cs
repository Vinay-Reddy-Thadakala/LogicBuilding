using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class SumOfDigitsOfANumber
    {
        static void Main(string[] args)
        {
            int number, temp, remainder, sumOfDigits = 0;

            Console.Write("Enter any number: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;

            while (number != 0)
            {
                remainder = number % 10;
                sumOfDigits += remainder;
                number /= 10;
            }

            Console.WriteLine($"Sum of digits of {temp} = {sumOfDigits}");
        }
    }
}
