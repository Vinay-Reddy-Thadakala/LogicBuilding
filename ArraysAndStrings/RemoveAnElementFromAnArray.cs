using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class RemoveAnElementFromAnArray
    {
        static void Main(string[] args)
        {
            int indexValue = 2;
            int[] original = { 1, 2, 3, 4, 5 };
            int[] updated = new int[original.Length - 1];

            for (int i = 0, j = 0; i < original.Length; i++)
            {
                if (i == indexValue)
                {
                    continue;
                }

                updated[j] = original[i];
                j++;
            }

            Console.WriteLine("Before removing the element.");
            foreach (int element in original)
            {
                Console.Write(element + ", ");
            }

            Console.WriteLine("\nAfter removing the element.");
            foreach (int element in updated)
            {
                Console.Write(element + ", ");
            }
        }
    }
}
