using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class InsertAnElementInAnArray
    {
        static void Main(string[] args)
        {
            int insertIndex = 1, insertValue = 2;
            int[] original = { 1, 3, 4, 5 };
            int[] updated = new int[original.Length + 1];

            for (int i = 0, j = 0; i < updated.Length; i++)
            {
                if (i == insertIndex)
                {
                    updated[i] = insertValue;
                }
                else
                {
                    updated[i] = original[j];
                    j++;
                }
            }

            Console.WriteLine("Before inserting element.");
            foreach (int element in original)
                {
                    Console.Write(element + ", ");
                }

            Console.WriteLine("\nAfter inserting element.");
            foreach (int element in updated)
            {
                Console.Write(element + ", ");
            }
        }
    }
}
