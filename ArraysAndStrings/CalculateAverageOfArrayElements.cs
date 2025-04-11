using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class CalculateAverageOfArrayElements
    {
        static void Main(string[] args)
        {
            double sumOfElements = 0, totalElements = 0, averageOfElements = 0;
            double[] elements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (double element in elements)
            {
                sumOfElements += element;
            }

            foreach (double element in elements)
            {
                totalElements++;
            }

            averageOfElements = sumOfElements / totalElements;

            //using predefined methods
            //averageOfElements = Queryable.Average(elements.AsQueryable());

            Console.WriteLine($"Average of array elements is {averageOfElements}");
        }
    }
}
