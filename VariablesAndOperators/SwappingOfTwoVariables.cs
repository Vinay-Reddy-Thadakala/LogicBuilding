using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class SwappingOfTwoVariables
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.Write("Enter a value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value: ");
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a value is " + a);
            Console.WriteLine("b value is " + b);
        }
    }
}
