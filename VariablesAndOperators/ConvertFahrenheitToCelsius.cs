using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class ConvertFahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            float f, c;
            Console.Write("Enter temperature in fahrenheit: ");
            f = float.Parse(Console.ReadLine());
            c = (f - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius: {0}", c);
        }
    }
}
