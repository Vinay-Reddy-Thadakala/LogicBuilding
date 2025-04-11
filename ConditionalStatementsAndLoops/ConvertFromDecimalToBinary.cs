using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class ConvertFromDecimalToBinary
    {
        static void Main(string[] args)
        {
            int decimalNum, temp, i;
            int[] binaryNum = new int[10];

            Console.Write("Enter any number: ");
            decimalNum = Convert.ToInt32(Console.ReadLine());
            temp = decimalNum;

            for (i = 0; decimalNum > 0; i++)
            {
                binaryNum[i] = decimalNum % 2;
                decimalNum /= 2;
            }

            ////We can also use while loop.
            //while (decimalNum > 0)
            //{
            //    binaryNum[i] = decimalNum % 2;
            //    decimalNum /= 2;
            //    i++;
            //}

            Console.Write($"Binary form of {temp} is ");

            for (i = i-1; i >= 0; i--)
            {
                Console.Write(binaryNum[i]);
            }

            ////Using this method we have face problem with some numbers like 10, 12, 50 etc..
            //int decimalNum, temp, remainder, revBinaryNum = 0;

            //Console.Write("Enter any number: ");
            //decimalNum = Convert.ToInt32(Console.ReadLine());
            //temp = decimalNum;

            //while(decimalNum != 0)
            //{
            //    remainder = decimalNum % 2;
            //    revBinaryNum = revBinaryNum * 10 + remainder;
            //    decimalNum /= 2;
            //}

            //int remainder2, binaryNum = 0;

            //while(revBinaryNum != 0)
            //{
            //    remainder2 = revBinaryNum % 10;
            //    binaryNum = binaryNum * 10 + remainder2;
            //    revBinaryNum /= 10;
            //}

            //Console.WriteLine($"Binary form of {temp} is {binaryNum}");
        }
    }
}
