using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class CountBlanksTabsAndNewlinesInString
    {
        static void Main(string[] args)
        {
            string characters;
            int countBlanks = 0, countTabs = 0, countNewlines = 0;

            characters = "Hello\tWorld\nThis is Vinay.\nTabs\tand spaces are here.";

            foreach (char character in characters)
            {
                if (character == ' ')
                {
                    countBlanks++;
                }
                else if (character == '\t')
                {
                    countTabs++;
                }
                else if (character == '\n')
                {
                    countNewlines++;
                }
            }

            Console.WriteLine($"There are {countBlanks} blanks, {countTabs} tabs and {countNewlines} new lines.");
        }
    }
}
