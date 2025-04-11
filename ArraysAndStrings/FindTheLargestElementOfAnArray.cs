using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class FindTheLargestElementOfAnArray
    {
        static void Main(string[] args)
        {
            int i, j, temp = 0;
            int[] elements = { 2, 5, 4, 3, 1 };

            for (i = 0; i < elements.Length; i++)
            {
                for (j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] < elements[j])
                    {
                        temp = elements[j];
                        elements[j] = elements[i];
                        elements[i] = temp;
                    }
                }
            }

            Console.WriteLine($"Largest number in  an array is {elements[0]}");
        }
    }
}
