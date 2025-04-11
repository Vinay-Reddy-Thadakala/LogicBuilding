using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class CountVowelsAndConsonantsInString
    {
        static void Main(string[] args)
        {
            string characters;
            int vowelCount = 0, consonantCount = 0;            

            Console.Write("Enter any string: ");
            characters = Console.ReadLine();

            foreach (char character in characters)
            {
                switch (character)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                    default:
                        consonantCount++;
                        break;
                }
            }

            Console.WriteLine($"There are {vowelCount} vowels and {consonantCount} consonants in {characters}");
        }
    }
}
