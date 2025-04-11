using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class ConvertUpperCaseToLowerCase
    {
        static void Main(string[] args)
        {
            char upperCaseLetter, lowerCaseLetter;
            int upperCaseAscii, lowerCaseAscii;

            Console.Write("Enter any small letter: ");
            upperCaseLetter = Convert.ToChar(Console.ReadLine());

            upperCaseAscii = upperCaseLetter;
            lowerCaseAscii = upperCaseAscii + 32;

            lowerCaseLetter = Convert.ToChar(lowerCaseAscii);

            Console.WriteLine($"Lower case of {upperCaseLetter} is {lowerCaseLetter}");
        }
    }
}
