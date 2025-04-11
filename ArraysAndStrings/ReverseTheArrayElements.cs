using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class ReverseTheArrayElements
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] elements = { 3, 2, 5, 4, 1};
            int[] revElements = new int[elements.Length];

            for (i = 0, j = elements.Length - 1; i < elements.Length && j >= 0; i++, j--)
            {
                revElements[i] = elements[j];
            }

            foreach (int element in revElements)
            {
                Console.Write(element + ", ");
            }
        }
    }
}
