using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class FindAsciiValueOfACharacter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any character: ");
            char character = Convert.ToChar(Console.ReadLine());
            int asciiValue = character;
            Console.Write("ASCII value of " + character + " is " + asciiValue);
        }
    }
}
