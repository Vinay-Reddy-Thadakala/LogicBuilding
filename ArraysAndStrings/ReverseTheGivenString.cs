using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class ReverseTheGivenString
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.Write("Enter any string: ");
            string normalStr = Console.ReadLine();
            StringBuilder reversedStr = new StringBuilder();

            foreach (char letter in normalStr)
            {
                count++;
            }

            char[] charArray = new char[count];

            foreach (char letter in normalStr)
            {
                charArray[count - 1] = letter;
                count--;
            }

            foreach (char letter in charArray)
            {
                reversedStr.Append(letter);
            }

            Console.WriteLine($"Reverse string is {reversedStr}");
        }
    }
}
