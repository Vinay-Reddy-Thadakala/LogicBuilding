using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class StandardDeviationOfArrayElements
    {
        static void Main(string[] args)
        {
            double sumOfElements = 0, mean, numerator = 0, standardDeviation = 0;
            double[] elements = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (double element in elements)
            {
                sumOfElements += element;
            }

            mean = sumOfElements / elements.Length;

            foreach (double element in elements)
            {
                numerator += Math.Pow(element - mean, 2);
            }

            standardDeviation = Math.Sqrt(numerator / elements.Length);

            Console.WriteLine($"The standard deviation is {standardDeviation}");
        }
    }
}
