using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsAndLoops
{
    class CheckCharacterIsAlphabetOrNot
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any character: ");
            char character = Convert.ToChar(Console.ReadLine());
            int asciiValue = character;
            
            if ((asciiValue >= 65 && asciiValue <= 90) || (asciiValue >= 97 && asciiValue <= 122))
            {
                Console.WriteLine("It is an alphabet.");
            }
            else
            {
                Console.WriteLine("It is not an alphabet.");
            }
        }
    }
}
