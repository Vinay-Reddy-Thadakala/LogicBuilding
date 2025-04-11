using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class FindSquareOfANumber
    {
        static void Main(string[] args)
        {
            int n, square;
            Console.Write("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            square = n * n;

            Console.WriteLine("Square of " + n + "is " +  square);
        }
    }
}
