using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class CalculateLengthOfAString
    {
        static void Main(string[] args)
        {
            int length = 0;
            string characters;

            Console.Write("Enter any string: ");
            characters = Console.ReadLine();

            foreach (char character in characters)
            {
                length++;
            }

            Console.WriteLine($"Length of a {characters} is {length}");
        }
    }
}
