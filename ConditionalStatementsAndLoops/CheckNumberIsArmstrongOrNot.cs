using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CheckNumberIsArmstrongOrNot
    {
        static void Main(string[] args)
        {
            ulong number, temp1, temp2, remainder, count = 0, power = 1, result = 0;

            Console.Write("Enter any number: ");
            number = Convert.ToUInt64(Console.ReadLine());
            temp1 = temp2 = number;

            while (number != 0)
            {
                number = number / 10;
                count++;
            }

            while (temp1 != 0)
            {
                remainder = temp1 % 10;

                for (ulong i = 1; i <= count; i++)
                {
                    power *= remainder;
                }

                result += power;
                power = 1;
                temp1 /= 10;
            }

            if (temp2 == result)
            {
                Console.WriteLine($"{temp2} is a armstrong number.");
            }
            else
            {
                Console.WriteLine($"{temp2} is not a armstrong number.");
            }
        }
    }
}
