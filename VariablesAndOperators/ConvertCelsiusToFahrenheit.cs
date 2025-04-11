using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class ConvertCelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            float c, f;
            Console.Write("Enter temperature in celsius: ");
            c = float.Parse(Console.ReadLine());
            f = (c * 9 / 5) + 32;
            Console.WriteLine("Temperature in fahrenheit: {0}", f);
        }
    }
}
