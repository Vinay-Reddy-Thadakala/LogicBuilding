using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class FindAreaOfRectangle
    {
        static void Main(string[] args)
        {
            float l, b, area;
            Console.Write("Enter length of rectangle: ");
            l = float.Parse(Console.ReadLine());
            Console.Write("Enter breadth of rectangle: ");
            b = float.Parse(Console.ReadLine());
            area = l * b;
            Console.WriteLine("Area of rectangle is " + area);
        }
    }
}
