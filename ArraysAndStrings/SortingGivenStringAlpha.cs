using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class SortingGivenStringAlpha
    {
        static void Main(string[] args)
        {
            int temp;
            string characters;
            StringBuilder sortedCharacters = new StringBuilder();

            Console.Write("Enter any string: ");
            characters = Console.ReadLine().ToLower();

            int[] asciiValues = new int[characters.Length];

            for (int i = 0; i < characters.Length; i++)
            {
                asciiValues[i] = (int)characters[i];
            }

            for (int i = 0; i < asciiValues.Length; i++)
            {
                for (int j = i + 1; j < asciiValues.Length; j++)
                {
                    if (asciiValues[i] > asciiValues[j])
                    {
                        temp = asciiValues[j];
                        asciiValues[j] = asciiValues[i];
                        asciiValues[i] = temp;
                    }
                }
            }

            foreach (int asciiValue in asciiValues)
            {
                sortedCharacters.Append(((char)asciiValue));
            }

            Console.WriteLine($"Sorted string of {characters} is {sortedCharacters}");
        }
    }
}
