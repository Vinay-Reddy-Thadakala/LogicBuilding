using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class ConvertLowerCaseToUpperCase
    {
        static void Main(string[] args)
        {
            char lowerCaseLetter, upperCaseLetter;
            int lowerCaseAscii, upperCaseAscii;

            Console.Write("Enter any lower case letter: ");
            lowerCaseLetter = Convert.ToChar(Console.ReadLine());

            lowerCaseAscii = lowerCaseLetter;
            upperCaseAscii = lowerCaseAscii - 32;

            upperCaseLetter = Convert.ToChar(upperCaseAscii);

            Console.WriteLine($"Upper case of {lowerCaseLetter} is {upperCaseLetter}");
        } 
    }
}
