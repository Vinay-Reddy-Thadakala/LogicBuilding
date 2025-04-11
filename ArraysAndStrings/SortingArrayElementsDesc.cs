using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class SortingArrayElementsDesc
    {
        static void Main(string[] args)
        {
            int i, j, temp;
            int[] elements = { 1, 5, 3, 2, 4 };

            for (i = 0; i < elements.Length; i++)
            {
                for (j = i + 1; j < elements.LongLength; j++)
                {
                    if (elements[i] < elements[j])
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }

                Console.Write(elements[i] + ", ");
            }
        }
    }
}
