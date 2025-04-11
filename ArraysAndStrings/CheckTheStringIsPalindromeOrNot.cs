using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class CheckTheStringIsPalindromeOrNot
    {
        static void Main(string[] args)
        {
            string characters;
            StringBuilder revCharacters = new StringBuilder();

            Console.Write("Enter any string: ");
            characters = Console.ReadLine().ToLower();

            for (int i = characters.Length -1; i >= 0; i--)
            {
                revCharacters.Append(characters[i].ToString());
            }

            if (characters == revCharacters.ToString())
            {
                Console.WriteLine($"{characters} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{characters} is not a palindrome.");
            }
        }
    }
}
