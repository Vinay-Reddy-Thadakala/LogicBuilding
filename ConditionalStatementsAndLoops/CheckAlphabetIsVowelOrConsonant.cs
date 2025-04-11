using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CheckAlphabetIsVowelOrConsonant
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any alphabet: ");
            char letter = Convert.ToChar(Console.ReadLine());
            switch (letter)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("it is a vowel.");
                    break;
                default:
                    Console.WriteLine("it is a consonant.");
                    break;
            }
        }
    }
}
