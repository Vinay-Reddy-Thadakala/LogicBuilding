using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class FindAsciiValueOfAString
    {
        static void Main(string[] args)
        {
            string word;
            StringBuilder asciiValue = new StringBuilder();

            Console.Write("Enter any string: ");
            word = Console.ReadLine();
            
            foreach (char letter in word)
            {
                asciiValue.Append((int)letter);
            }

            Console.WriteLine($"ASCII value of {word} is {asciiValue}");
        }
    }
}
