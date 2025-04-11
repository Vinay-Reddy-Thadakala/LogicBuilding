using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class SwappingOfTwoVariablesWithoutTemp
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter a value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a value is " + a);
            Console.WriteLine("b value is " + b);
        }
    }
}
