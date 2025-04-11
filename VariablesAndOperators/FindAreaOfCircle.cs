using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndOperators
{
    class FindAreaOfCircle
    {
        static void Main(string[] args)
        {
            float r, area;
            const float pie = 3.14f;
            Console.Write("Enter radius of circle: ");
            r = float.Parse(Console.ReadLine());
            area = pie * r * r;
            Console.WriteLine("Area of circle is " + area);
        }
    }
}
