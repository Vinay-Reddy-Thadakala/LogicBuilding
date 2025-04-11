using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CheckNumberIsPalindromeOrNot
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

            if (temp == reverse)
            {
                Console.WriteLine($"{temp} is a palindrome number.");
            }
            else
            {
                Console.WriteLine($"{temp} is not a palindrome number.");
            }
        }
    }
}
