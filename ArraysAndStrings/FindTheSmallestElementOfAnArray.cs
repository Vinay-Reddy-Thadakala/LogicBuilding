using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class FindTheSmallestElementOfAnArray
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int[] elements = { 3, 2, 1, 5, 4 };

            for (i = 0; i < elements.Length; i++)
            {
                for (j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] > elements[j])
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }
            }

            Console.WriteLine($"Smallest element from an array is {elements[0]}");
        }
    }
}
