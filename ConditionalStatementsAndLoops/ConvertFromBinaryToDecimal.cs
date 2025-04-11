using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class ConvertFromBinaryToDecimal
    {
        static void Main(string[] args)
        {
            int number, temp, remainder, basePower = 1, multiply, decimalNumber = 0;

            Console.Write("Enter binary number: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number; 

            while (number != 0)
            {
                remainder = number % 10;
                multiply = remainder * basePower;
                decimalNumber += multiply;
                basePower *= 2;
                number /= 10;
            }

            Console.WriteLine($"Decimal number of {temp} is {decimalNumber}");
        }
    }
}
