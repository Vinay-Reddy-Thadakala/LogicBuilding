using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class RemoveCharactersFromStringExceptAlphabets
    {
        static void Main(string[] args)
        {
            string characters;
            StringBuilder alphabets = new StringBuilder();

            Console.Write("Enter any string: ");
            characters = Console.ReadLine();            

            foreach (char character in characters)
            {
                if(((int)character >= 65 && (int)character <= 90) || ((int)character >= 97 && (int)character <= 122))
                {
                    alphabets.Append(character);
                }
            }

            Console.WriteLine($"After removing symbols form {characters} the result is {alphabets}");
        }
    }
}
