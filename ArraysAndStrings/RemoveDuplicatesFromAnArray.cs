using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class RemoveDuplicatesFromAnArray
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 3, 4, 5 };
            int[] uniqueElements = new int[elements.Length - 1];
            int uniqueCount = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                bool isDuplicate = false;

                // Check if elements[i] is already in uniqueElements[]
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (elements[i] == uniqueElements[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If not a duplicate, add to uniqueElements[]
                if (!isDuplicate)
                {
                    uniqueElements[uniqueCount] = elements[i];
                    uniqueCount++;
                }
            }

            // Print unique elements
            Console.WriteLine("Unique elements:");
            foreach (var element in uniqueElements)
            {
                Console.Write(element + ", ");
            }
        }
    }
}
