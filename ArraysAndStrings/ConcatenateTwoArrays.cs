using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class ConcatenateTwoArrays
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] firstArray = { 1, 2, 3, 4, 5};
            int[] secondArray = { 6, 7, 8, 9, 10 };
            int newArrayLength = firstArray.Length + secondArray.Length;
            int[] newArray = new int[newArrayLength];
            
            for (int i = 0; i < firstArray.Length; i++)
            {
                newArray[i] = firstArray[i];
            }

            for (int i = firstArray.Length; i < newArrayLength; i++)
            {
                newArray[i] = secondArray[count];
                count++;
            }

            foreach (int elements in newArray)
            {
                Console.Write(elements + ", ");
            }
        }
    }
}
